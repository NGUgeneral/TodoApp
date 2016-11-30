# TodoApp
Simple Todo App with Saving the state of objects via Serialization

The App uses MVVM architecture. During the work with app - user manipulates with only one object Todo (which is a task). The Todo's are stored in a AppSession.
Apps are not getting removed, but getting deactivated and are not accessible after that.
After initial Task creation - its getting added to the AppSession tasks list, which is getting serialized on closing of the application window, stored into the data.bin file.
On Load of the Main Window of the application - it retrieves the Todo's list by de-serializing the data.bin stream into a objects list and populates the app with active tasks.

App has been created in one day as part of the test tasks for an interview.
