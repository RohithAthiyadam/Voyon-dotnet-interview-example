# Voyon .Net interview example
The topic of this coding example is a task list. When you download the repository, everything is already built so the application can display a list of tasks, also the application will already contain a set of tasks - those tasks are the ones you should work on during this coding example. They are about refactoring the existing code base, adding some extensions to it or only answering some questions.

## What should you do?
- Spend 2-3 hours working on the example
- Setup the solution as described in the "Setup" below
- Follow the "Guidelines" described below for your development
- You will find the tasks you need to solve in the application itself once you start and open it in your browser
- There are many tasks which in total will most probably take longer then 2-3 hours. Nevertheless try to work on each task. For the tasks you can't solve in the time, add some comments in the solution where and how you would solve it (e.g. pseudocode).
- The tasks in the example are ordered by complexity (easier tasks at the top), the are created to cover technical skills from junior up to senior level. If you don't know how to solve a task, try to explain your steps on how you would tackle the task.
- When you are done with the task, send us an email with a link to your repository.

## Guidelines
- Work in a public github repository so we can review your code
- Use best practices whenever you can
- Use gitflow and work on seperarte branches for each task
- Before submitting the code to us make sure you merged everything back to master branch cause this is the branch we will review

## Setup
- Download this repo as a zip to your machine
- Create a public github repo on your account
- Commit to code to your repo
- Open the solution at /src/Voyon.DotNet.Interview.sln in your Visual studio
- Restore nuget packages for the solution
- In the class Voyon.DotNet.Interview.Core.Database.DbContext edit the const field DATABASE_PATH to a path in the root of your repo eg. @"C:\Source\database.json" if your repository is placed at C:\Source.
- Start the application from visual studio
- You should see the task list for this example in your browser now
- Make sure the file database.json was created where you expected and is commited to your git repo

## Need help?
If you should have any problems during the setup or the work on the project don't hesitate to contact your contact for the interview
