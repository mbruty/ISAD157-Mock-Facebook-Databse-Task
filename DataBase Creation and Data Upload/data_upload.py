import config
import pandas as pd
import numpy as np
import random
import time
import mysql.connector
import asyncio

start = time.time()
## 00 single, 01 Engaged, 10 Married, 11 Complicated
relationship_types = [int('00', base = 2), int('01', base = 2), int('10', base = 2), int('11', base = 2)]
date_format = '%Y-%m-%d'

# Key value list {work place name : work place id}
workplaces_dict = {}
# {uni name : uni id}
universities_dict = {}
PATH = config.PATH
# We're just going to put every query in to this list, then execute it over the pool
# Probs not the best way of doing it, but the actual queries are what take a long time
global queries_list

queries_list = []

def fill_queries():

    ## USERS ##
    df = pd.read_csv(PATH + 'facebook_users_5000_max.csv')
    for index, row in df.iterrows():
        # Only male or female in the dataset, but using 2 BITS so 10 = unspecified
        gender = int('00', base = 2) if row['Gender'] == 'Male' else int('01', base = 2)
        #Random choice for a relationship status
        relationship_status = rand_choice(relationship_types)
        query = "INSERT INTO Users (userID, firstName, lastName, gender, homeTown, currentCity, relationshipStatus) VALUES ({0}, \"{1}\", \"{2}\", {3}, \"{4}\", \"{5}\", {6});".format(
        row['UserID'], row['FirstName'], row['LastName'], gender, row['Hometown'], row['City'], relationship_status)
        queries_list.append(query)



    ## WORK PLACES ##
    df = pd.read_csv(PATH + 'workplace.csv')

    num_workplaces = 0
    for index, row in df.iterrows():
        if row['Workplace'] not in workplaces_dict and not pd.isna(row['Workplace']):
            num_workplaces += 1
            workplaces_dict.update({row['Workplace'] : num_workplaces})
            query = "INSERT INTO Workplaces(workplaceName) VALUES(\"{0}\");".format(row['Workplace'])
            queries_list.append(query)




    ## UNIS ##
    df = pd.read_csv(PATH + 'universities.csv')

    universities_dict = {}
    num_unis = 0

    for index, row in df.iterrows():
        if row['University'] not in universities_dict and not pd.isna(row['University']):
            num_unis += 1
            universities_dict.update({row['University'] : num_unis})
            query = "INSERT INTO Universities(universityName) VALUES(\"{0}\");".format(row['University'])
            queries_list.append(query)




    ## WORKERS ##
    df = pd.read_csv(PATH + 'workplace.csv')
    df['date_started'] = np.empty((len(df), 0)).tolist()
    df['date_left'] = np.empty((len(df), 0)).tolist()
    date_format = '%Y-%m-%d'

    # Drop any user over 5,000 - Data file has been made smaller to lower load on uni servers
    workerIndex = df[df['UserID'] > 5000].index
    df.drop(workerIndex , inplace=True)

    for index, row in df.iterrows():
        if not pd.isna(row['Workplace']):
            if row['UserID'] == df.iloc[index - 1, 0]:
                df.iloc[index, 2] = rand_date(df.iloc[index - 1, 3], "2020-1-1", date_format, random.random())
            else:
                df.iloc[index, 2] = rand_date("1980-1-1", "2020-1-1", date_format, random.random())
            if row['UserID'] == df.iloc[index + 1, 0]:
                df.iloc[index, 3] = rand_date(df.iloc[index, 2], "2020-1-1", date_format, random.random())
            #Fetch the updated row
            curr_row = df.iloc[index, :]
            sql = ""
            if curr_row['date_left'] == []:
                query = "INSERT INTO Workers (userID, workplaceID, dateStarted) VALUES({0}, {1}, \"{2}\");".format(
                curr_row['UserID'], workplaces_dict[curr_row['Workplace']], curr_row['date_started'])
            else:
                query = "INSERT INTO Workers (userID, workplaceID, dateStarted, dateLeft) VALUES({0}, {1}, \"{2}\", \"{3}\");".format(
                curr_row['UserID'], workplaces_dict[curr_row['Workplace']], curr_row['date_started'], curr_row['date_left'])

            queries_list.append(query)


    ## STUDENTS ##
    df = pd.read_csv(PATH + 'universities.csv')
    df['date_started'] = np.empty((len(df), 0)).tolist()
    df['date_left'] = np.empty((len(df), 0)).tolist()
    date_format = '%Y-%m-%d'

    # Drop any user over 5,000 - Data file has been made smaller to lower load on uni servers
    studentIndex = df[df['UserID'] > 5000].index
    df.drop(studentIndex , inplace=True)
    for index, row in df.iterrows():
        if not pd.isna(row['University']):
            if row['UserID'] == df.iloc[index - 1, 0]:
                df.iloc[index, 2] = rand_date(df.iloc[index - 1, 3], "2020-1-1", date_format, random.random())
            else:
                df.iloc[index, 2] = rand_date("1980-1-1", "2020-1-1", date_format, random.random())
            if row['UserID'] == df.iloc[index + 1, 0]:
                df.iloc[index, 3] = rand_date(df.iloc[index, 2], "2020-1-1", date_format, random.random())
            #Fetch the updated row
            curr_row = df.iloc[index, :]
            sql = ""
            if curr_row['date_left'] == []:
                query = "INSERT INTO Students (userID, uniID, dateStarted) VALUES({0}, {1}, \"{2}\");".format(
                curr_row['UserID'], universities_dict[curr_row['University']], curr_row['date_started'])
            else:
                query = "INSERT INTO Students (userID, uniID, dateStarted, dateLeft) VALUES({0}, {1}, \"{2}\", \"{3}\");".format(
                curr_row['UserID'], universities_dict[curr_row['University']], curr_row['date_started'], curr_row['date_left'])

            queries_list.append(query)



    ## FRIENDSHIPS ##
    df = pd.read_csv(PATH + 'facebook-friendships-5000_max.csv')
    for index, row in df.iterrows():
        query = "INSERT INTO Friendships(userID_1, userID_2, isAccepted) VALUES ({0}, {1}, {2});".format(
        row['UserID_1'], row['UserID_2'], True)
        queries_list.append(query)



    ## MESSAGES ##
    df = pd.read_csv(PATH + 'messages.csv')

    indexMessages = df[df['UserID_1'] > 5000].index
    df.drop(indexMessages , inplace=True)

    indexMessages = df[df['UserID_2'] > 5000].index
    df.drop(indexMessages , inplace=True)

    for index, row in df.iterrows():
        query = "INSERT INTO Messages(senderID, recipientID, sentTime, messageText, isRead) VALUES({0}, {1}, \"{2}\", \"{3}\", {4});".format(
        row['UserID_1'], row['UserID_2'], row['Date_Time'], row['Message'], True)
        queries_list.append(query)


def rand_choice(list):
    return list[random.randrange(0, len(list))]

def rand_date(start, end, format, prop):
    stime = time.mktime(time.strptime(start, format))
    etime = time.mktime(time.strptime(end, format))
    ptime = stime + prop * (etime - stime)
    return time.strftime(format, time.localtime(ptime))

async def do_work(q):
    while True:
        try:
            query = await q.get()
            cursor.execute(query)
            conn.commit()
        except Exception as e:
            print(e)
            print(query)
            conn.rollback()
        q.task_done()



async def main():
    q = asyncio.Queue()
    num_threads = 32

    cursor.execute("SET FOREIGN_KEY_CHECKS=0")

    for x in queries_list:
        await q.put(x)

    tasks = []

    for i in range(num_threads):
        task = asyncio.create_task(do_work(q))
        tasks.append(task)

    await q.join()
    end = time.time()
    print(end - start)
    cursor.execute("SET FOREIGN_KEY_CHECKS=1")


fill_queries()
conn = mysql.connector.connect(
    host=config.host,
    user=config.user,
    passwd=config.passwd,
    database=config.database
)
print("Done creating queries!")
cursor = conn.cursor()
asyncio.run(main())
