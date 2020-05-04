
# Mock-Facebook-Databse-Task

## The Scenario
We have been given the task of designing a relational database from a Client-Like brief. The data had to be normalised to 3NF. UML diagrams were then created to plan the whole task, then the C# code was created from the UML diagrams. 

## Python Part:
###### Note One: The python part is only submitted to have on my github and isn't submitted for marking
###### Note Two: No marks were available for the python part, it was just a fun side project that allowed me to upload the data a lot quicker than the 4-6 hours my course mates were reporting it was taking
### JupyterNotebook
This document contains the code that created the mock data that wasn't provided with the dataset. Each segment contains the code for uploading to each different table, along with the 'df.Head()' which shows the first 5 rows in the data frame. As this was un-parallelised it takes a while to upload as each part gets 'stuck' on sending the data to the database server. This took 2 hours and 1 minute to upload to  the database server.

### data_upload.py
This document contains the full code for uploading to the database server. In it, I create a list the queries to send to the database. Once all the data has been placed in the list, it is placed in a queue that's waiting to be executed. 32 Threads are spawned and upload the data as fast as the server can accept it. This took 1 hour and 40 minutes to upload.
###### Note: FOREIGN_KEY_CHECKS had to be turned off, as it's asynchronous there were rare cases where a piece of data was uploaded whilst it's foreign key was still in queue waiting to be uploaded. Generally this isn't a good idea, but as I konw the dataset is complete and not missing any entries, it's fine
## SQL Part
This is just a document that contains the code for creating the table (and deleting the table, then re-creating it if you mess up).

## The C# part
Firstly, all of the DataBase class has been made asynchronous. This is because everything is ran off of one main thread, unless you make it run with multiple threads. This results in the graphics thread being locked for the ~0.1 seconds it takes to query the database. Furthermore, if a connection cannot be established to the database, the whole program can lock up for the 30 seconds it takes for the connection to time out. This results in the program being more snappy, as it's still running whilst waiting on the data. The asynchronous programming was done by using the built-in Task\<T\> method. 

In this assignment, no marks were available for the design of the UI. This is why it's vanilla WindowsForms without any custom Eye-Catching elements. If you want to see a task where UI was a focus, [look here](https://github.com/mbruty/AirBnb-DataVisualisation).

UI considerations - input-validation has been implemented for message text, user gender and user relationship status. The text box turns red when the data is breaking a constraint and goes back to normal once it's correct. Text boxes are displayed greyed-out when it's read-only. Text is large enough so that it is readable by most users. The only possible accessibility problem is when a text box turns red, if a user has protanopia, the red-colour might appear slightly greyed-out leading them to believe that the text-box is in read-only mode. However, as said earlier, this assignment focuses on other aspects of programming, thus this is more than what was required.
#### Self-lead-learning
To obtain the highest marks within this assignment, I had to under-take significant self lead learning. The elements that contain this are the Asynchronous programming within the DataBase Class and Inheritance within the FriendRequest and MultiMeassage Forms. There are also some more-complex SQL queries within the DataBase Class which we have not covered within lectures.

## The Graphs
