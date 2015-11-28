# Design Document - ChronoTrack

## High Concept

ChronoTrack is a desktop application written in C# using the .Net Framework. It strives to provide a simple and accurate method of keeping time of tasks as week as promoting productivity by optionally following the Pomodoro technique.

## Table of Contents

[TOC]

## Feature Releases

### Version 0.1

Time Estimate: 

#### Deliverables

[Tasks](#tasks)

[Categories](#categories)

[Sessions](#sessions)

[Menubar](#menubar)

[Saving](#saving-a-project)

[Loading](#loading-a-project)

[Auto-save](#auto-save)

### Version 0.2

Time Estimate: 

#### Deliverables

[ ] WPF Main Application Wireframe

[Task Groups](#task-groups)

[Break alerts](#break-alerts)

[Active task alerts](#active-task-alerts)

[Settings](#settings)

### Version 0.3

Time Estimate: 

#### Deliverables

[Timing Techniques setup](#timing-techniques)

[Other productivity timing default setups](#)

[Extensible alert/setup for custom scheduling](#)

### Version 0.4

Time Estimate: 

#### Deliverables

[Integrate file saving with multiple web services](#web-service-integration-for-projects)

### Version 0.5

Time Estimate: 

#### Deliverables

[Integration with multiple task tracking services](#web-service-integration-for-tasks)

### Version 0.6

Time Estimate: 

#### Deliverables

[Chart View](#chart-view)

### Version 0.7

Time Estimate: 

#### Deliverables

[Auto-update](#auto-update)

### Version 1.0

Time Estimate: 

#### Deliverables

[README](#readme)

[User manual/documentation for use](#manual)

[Code documentation and cleanup](#)

[License](#license)

## Features

### Tasks

Time Estimate:

Tasks will be a database table of the Task object type. Each task will have a unique id and name, as well as a possible reference to a parent category.

###  Active Tasks

Time Estimate:

Active Tasks are Tasks with an active Session. These should be excluded from the Inactive Tasks list. When a Task is added to the Active Tasks list, if it has a Category, the Category should also have a new Session created for it and be moved to the Active Tasks list.

### Inactive Tasks

Time Estimate:

Inactive Tasks are Tasks without an active Session. When an Active Task is made inactive, any of it’s session (of which there should only ever be one active) would receive it’s endTime and become closed. If the Tasks Category has no more Tasks in the Active Task list with the same Category, the Category’s active session would also receive it’s endTime and become closed, moving to the Inactive Tasks list.

### Sessions

Time Estimate:

Sessions will be a database table of the Session object type. Each Session with have either a taskId or a categoryId as well as a startTime and an endTime. If a Session does not have an endTime, it is considered to be an Active Session. Once a Session has both a startTime and an endTime, it is considered to be a Closed Session.

### Initialization Error Checking

Time Estimate:

When a Project is loaded, it should be checked to make sure the database does not contain any erroneous data.

### Categories

Time Estimate:

Categories are similar to tasks, except that they cannot have a category of their own. They should do some fancy color coding which would cause all tasks of that category to be colored the same.

### Menubar

Time Estimate:

The menubar should contain all commands that the user can execute.

File
: New Project
: Open Project
: Save Project
: Save Project As
: Exit

Edit

View

Help

### Project

Time Estimate:

Users should be able to create a new project. Which will be a SQLite database. This will retain all project settings and data. Program settings will be stored outside of this.

### Settings

Time Estimate:

Program Settings should be saved in the user directory as an .ini or .json file.
Project Settings should be saved in the user directory in a database.

### Creating a new project

Time Estimate:

Users should be able to create a new project.

### Saving a project

Time Estimate:

Users should be able to save a project to disk. If in the ProjectSettings, the project already has a directory and filename set that is valid, the file will be saved to that directory with no overwrite alert. If the directory does not exist, the player should receive a message asking to create it.

### Saving a project as

Time Estimate:

Users should be able to save a project to disk as a new project file.

### Opening a project

Time Estimate:

Users should be able to load a previously saved project.

### Auto-Save

Time Estimate:

Users should be able to enable Auto-Save on a project. This will actively fold the file so that it cannot be modified by an outside source. This has the added benefit of disabling Initialization Error Checking

### Task Groups

Time Estimate:

### Alerts

Time Estimate:

Alerts are pop up windows that have settings to appear on top or under and only blink orange in the taskbar.

### Break Alerts

Time Estimate:

Break alerts appear according to your timing technique and remind you to take a quick break. Extra features on this could include sending an alert or text after a certain amount of time to tell you when break time is over.

### Active Task Alerts

Time Estimate:

The active task alert appears occasionally to make sure you are actually working on the active tasks.

### Timing Techniques

Time Estimate:

Timing techniques such as Pomodoro should be included by default. Users should be able to create custom timing techniques as well as import and export.
Research: https://en.wikipedia.org/wiki/Pomodoro_Technique

### Web service integration for projects

Time Estimate:

This should provide the functionality of syncing the document to a web service. Possible services include:
Google Docs
Research: https://developers.google.com/drive/

### Web service integration for tasks

Time Estimate:

This should provide the functionality for syncings tasks/issues from another service. This could also extend to posting time spent on an issue into that service, but that depends on the services hooks.
This should also provide a system for automatically loading tasks. For example, if we were using Trello, of you had a task categorized as programming, when the task is loaded into Time Lord, it also had the task for programming, and creates it if necessary.

Possible services include:
:Trello:
GitHub Issues

Research: https://trello.com/docs/
Research: https://developer.github.com/v3/issues/

### License

Time Estimate:

Need to lookup licenses, open source, free for personal use/commercial use, cannot be altered/reused/resold all that stuff.

Research: http://choosealicense.com/

### Chart View

Time Estimate:

Using Google.Visualization.Net should allow us to display the time spent on tasks and types of tasks easily.

Research: https://code.google.com/p/googlevisualizationsdotnet/

There may be other charting/graphing libraries that should be researched and considered.

### Auto Update

Time Estimate:

An automatic update system should be in place to provide users with a up-to-date experience with minimal effort on their end.

Research: https://github.com/Squirrel/Squirrel.Windows

Assess other tools that could be used or maybe rolling our own.

## Mockup

Things to add:
:Views (to see charts and data)

## Data Structure

### Project

### ProjectSettings

String directory

String fileName

String projectName

### Category

Int id

String name

String Color


### Task

Int id

String name

Int categoryId

### Session

Int taskId

Int categoryId

DateTime startTime

DateTime endTime





