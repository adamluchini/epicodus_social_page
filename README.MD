# Project Name
* Epicodex
* C#
* Week 5 Group Project
* 07.29.2016

## By
* Bo Zhao
* Adam Luchini
* Jim Klein
* Brittany Rausch

## Description
The Epicodex is a social media tool that encourages program-wide communication amongst students and instructors. After creating a profile, Epicodex allows a user to create new posts pertaining to a topic parameter of their choice. They also have the ability to reply to their own posts, or others created by fellow classmate's and instructors. A pair suggestion is also displayed for the user based on particular information they provided in their profile under two lists: "Perfect Matches" and "Good Matches".


## Specifications
The capabilities of the Epicodex are as follows:
* Displays a perfect pair suggestion individually based on their Myers-Briggs score.
  * Example: A user decides they want to perfectly match with someone who has a compatible Myers-Briggs score. If the selection in their profile was INFJ, Epicodex would generate a list of students who selected ENFP, the suggested compatible personality type according to the test.
* Displays a good pair suggestion individually based on their Myers-Briggs score.
  * Example: A user decides they want to match with someone who has a compatible Myers-Briggs score. If the selection in their profile was INFJ, Epicodex would generate a list of students who selected either ENFP or ESTJ, the suggested compatible personality types according to the test.
* Displays a perfect pair suggestion individually based on their experience level.
  * Example: A user who identifies as a beginner wants to pair with someone for the day. The pair suggestion will be a list of students who selected "expert" when making a profile.
* Displays a good pair suggestion individually based on their experience level.
  * Example: A user who identifies as a beginner wants to pair with someone for the day. The pair suggestion will be a list of students who selected "novice" when making a profile.
* Specific post types are visible to all Epicodus staff and students.
  * Example: An instructor wants to send an Epicodus wide message regarding a broken refrigerator in the kitchen. They will be able to create an "announcement" message that goes out to all students and staff regardless of specific class enrollment.
* Specific post types are only visible to Epicodus staff and students within that enrollment class.
  * Example: A C# student is having difficulty with an error message "CS 220" and can't resolve the issue. For help, they select "Question" from the topics list and writes a message asking if anyone has had this error message before. The post is then seen only by those who selected C# in their profile.
* Users are able to filter amongst post types.
  * Example: If a user wants to see only announcement posts, the "announcement" option is selected from the drop down menu and the page reloads hiding anything that wasn't tagged as "announcemnt".
* Comments can be applied to existing posts.
  * A C# student made a post under the "Questions" topic and the user found an answer. The user can add a comment to that post sharing the answer and can now be viewed by all C# students below the original post.


## Installation
* _Clone this repository_
* _Open SSMS_
* _Select File > Open > File and select the .sql files: band_tracker.sql & band_tracker_test.sql_
* _Save the file_
* _Click ! Execute_
* _Verify that the database has been created and the schema and/or data imported_
* _Open Windows PowerShell_
* _Navigate to project folder_
* _Run dnu restore in the command line_
* _Run dnx kestrel in the command line_
* _Open Google Chrome to localhost:5004_

## Technologies Used
HTML5, CSS, Bootstrap, SMSS, Razor, Nancy, PowerShell

## Contact
Feel free to contact us at:
(Brittany Rausch: berausch247@gmail.com, Adam Luchini: aluchini@gmail.com, Bo Zhao: zhaobo419@gmail.com, Jim Klein: sj.mesklein@gmail.com)

## License
This software is licensed under the MIT license

## Copyright (c) 2016 All Rights Reserved.
