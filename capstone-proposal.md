Michael Watkins
Meal Prep Planner

Purpose: To help people find tasty recipes to put into their meal prep calendar.

MVP features: Ability to access different recipes and put them into a daily planner. This will include saving up to a weeks worth of meal plans and persisting information in a mysql database. 

Tools etc: C#/.Net, MySQL, Spoontacular API.

Stretch goals: An interactive Month Calendar that you can click on different days to see what you have planned for food. User authentication is achieved by users creating a spoonacular account and inputing their unique hash code and username into a form that will allow them to access their specific calendar.

Stretch goal tools: Mainly a more indepth understanding of how spoonacular interacts with data and what is possible with it. At this point I think that my stretch goals will be achievable purely through the use of spoonaculars great api, but I haven't dug enough into it yet to know if my stretch goals will need additional tools or not.

### Research & Work Log
#### Friday, 02/18
* 8 - 9:30 Spent morning looking up scaffoliding and researching different approaches of meshing C#/.Net and React.
* 9:30 - 10:30 Considered what I wanted the project to achieve and briefly wrote capstone proposal.
* 10:30 - 11:30 Studied what is possible with the Spoonacular API.
* 1 - 2:30 Researched more about how C# and React communicate.
* 2:30 - 3:30 Looked through the code to see what I need and don't need to make the program work.
* 3:30 - 4:30 Researched how routes work in React.

#### Sunday, 02/20
* 4:30 - 5 Learned about the spa method that connects the C# to React in the Startup.cs file.

#### Wednesday, 02/23
* 6 - 7 Learned more about how to call api's and send them to the react front end. Briefly considered switching to a full c# app but decided against it for the moment.

#### Thursday, 02/24
* 3:30 - 4:00 Researched Spoonacular Api more and attempted to see what I would need to make an api call. Also updated my capstone proposal.

#### Friday, 02/25
* 8:09 - 8:39 Working towards making an API call. Reading through week 5 of the C# lessons.
* 8:39 - 9:09 Continuing to build the api call, focusing on the model at the moment, used json2csharp website to convert the api call to a model.
* 9:09 - 9:39 Built the api call, now trying to connect it to React.
* 9:39 - 10:09 Decided after looking through bugs and documentation to switch to a new project that is completely C#.
* 10:09 - 10:30 Added some files to the c# program as a baseline, taking an early lunch to destress after throwing out my old project.
* 11:50 - 12:20 Continuing to try and get the api call to appear on screen. Added several files in the models, controllers, and views folders.
* 12:20 - 12:49 Ran into a wall where I am not formatting my model correctly, will continue trying to get past this obstacle.
* 12:49 - 1:20 Figured out the last hurdle but now having an issue where local host is saying that this site can't provide a secure connection.
* 1:20 - 1:53 Trying to deserialize an object.
* 1:53 - 2:19 Continuing to try and deserialize an api call, thinking about switching to a different api call.
* 2:19 - 2:56 looking up how to deserialize json objects in google.
* 2:56 - 3:34 reading up on JArray and how to make it work.
* 3:34 - 3:55 Looking for a better formatted api, stepping away from the computer for 30 mins.
* 4:00 - 4:30 Ended up finding a way to make the spoonacular api work, on to the next hurdle.
* 4:30 - 4:48 Added in a front page that displays a full days worth of meals.
* 4:48 - 5:28 Researched Mysql and reread lessons on how to save information.

#### Sunday, 02/27
* 5:00 - 5:30  Attempting to add mysql db to the project, if it will work well with the api call has yet to be seen.
* 5:30 - 5:58 Got the api webpage to start up again, had to add entity framework into the using statements in startup.cs.
* 6:00 - 6:27 Relearned how Linq works and created a meals controller. Looking into how I'm going to get info from the API page to the database index page.
* 6:27 - 6:58 Got the db table set up and now going through errors trying to make it appear on the screen.
* 6:58 - 7:32 Got the database screen to appear. On to creating a form for users to put meal info into.
* 9:00 - 9:30 Now stuck trying to figure out how to get a form to appear on the api view. 
* 9:30 - 9:56 Rethought how my app will work and in the process of putting the form in.
* 9:56 - 10:28 Added in a details rough draft. Will have to redo the api call to change it to a better type of call.

#### Monday, 02/28
* 4:00 - 4:27 Added Update and delete functionality. Still need to clean it all up but starting to come together.
* 4:27 - 4:58 Researched a better api call from the spoonacular api.
* 4:58 - 5:27 Hit a block on how to pass a variable from a form into an api call.
* 5:27 - 6:26 Spent the past hour trying to find an example of a variable being taken from a form and put into an api call.
* 6:26 - 6:58 Found a promising youtube video that calls two different apis, will pursue that.
* 6:58 - 7:55 Finished the youtube video, very informative and got some ideas on how to implement my api call.

#### Monday, 03/07
* 9:00 - 9:36 Working on changing the api call I am making to make it more useful to the user.
* 9:36 - 10:00 Working on the api call.
* 10:00 - 10:29 Working on the index view to display the api call.
* 10:29 - 11:00 Trying to fix an ef bug.
* 11:00 - 11:30 Continuing to work on the api call.
* 11:30 - 11:57 Fixed the api call, now cleaning up the model info.

#### Tuesday, 03/08
* 9:00 - 9:30 Fixing up the api call.
* 11:00 - 11:30 Spent time thinking about what I want the project to look like.
* 11:30 - 12:09 Added stuff to the front and validating the db still works.
* 12:09 - 1:14 Confirmed that everything is working. On to styling!
* 1:14 - 1:27 Found a new bug, working on it now.
* 1:27 - 2:03 Continuing to research the bug!
* 2:03 - 2:55 Fixed the bug.
* 4:00 - 4:30 Created a color scheme for the website!
* 4:30 - 4:55 Trying to figure out how to make the css work.
* 4:55 - 5:33 Making headway, still making stuff though.
* 5:33 - 6:01 Continuing to work on css.
* 6:01 - 6:58 Playing with css and getting input from peers.

#### Wednesday, 03/09
* 9:00 - 9:30 Working with trying to get two models into one view.
* 9:30 - 10:00 Researching how to put two different models in the same page.
* 11:00 - 11:30 Continuing to attempt a combined view.
* 11:30 - 11:55 Continuing to research my issue.
* 11:55 - 12:27 Created a bug in the program, looking for it now.
* 12:27 - 1:10 Found the bug.
* 1:10 - 1:30 Spent some time thinking where I want to go next with the project.
* 1:30 - 1:58 Researched ActionLink and started implementing it.
* 1:58 - 2:49 Playing around with css and linking everything up.
* 2:49 - 3:20 Can't seem to get the details page to display correctly.
* 3:20 - 3:52 Resolved a display issue.
* 3:52 - 4:29 Continuing to connect things.
* 4:29 - 4:57 Trying to make a nav bar.
* 4:57 - 5:31 For some reason the css stylesheet is being unresponsive.
* 7:00 - 7:45 Got the stylesheet to be responsive, working on styling now.
* 7:45 - 8:30 Continuing to work on styling, mainly working on the nav bar.
* 8:30 - 9:00 Fixed the nav bar to a rough state.

#### Thursday, 03/10
* 9:30 - 9:45 Trying to get a link in the details page, currently not liking the => symbol.
* 9:45 - 9:58 Removed what I was trying to do in the details page, but now theres a bug, trying to stay calm and carry on.
* 9:58 - 10:29 Tried restarting my computer to see if the bug would be fixed that way, it did not fix the bug.
* 10:29 - 10:53 Continuing to work on the bug, getting peer suppport.
* 10:53 - 11:39 Figured out the bug, there was an issue with the database, had to manually create a new table.
* 11:39 - 11:56 Started the README, working on fleshing it out.
* 11:56 - 12:08 Finished README.

#### Friday, 03/11
* 12:00 - 12:30 Working on css. Realized what I really want to do is get a react frontend working so switching to that. Added a nuget called bridge that will hopefully help with that. It didn't but found a new article on the useSpa method I am going to hopefully use to connect things.
* 12:30 - 1:00 Came to the conclusion I would need to start a new project to make a react front end work. Will switch back to css.
* 1:00 - 1:28 Bridge broke the program, had to look up how to uninstall it. Back to css. For some reason the border wont show.
* 1:28 - 1:41 The css isn't being responsive for some reason.
* 1:41 - 2:44 Still have the same error where css that I deleted is still being displayed, attempted to update my computer and see if that affected anything and it didn't more googling ahead.