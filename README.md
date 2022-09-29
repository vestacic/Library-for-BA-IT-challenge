# Library-for-BA-IT-challenge
Library simulation for BA IT challenge

For the BA IT challenge I decided to develop a Windows form app using .NET framework.

About the app:
First form:
  The richtextbox displays the lists of the books in the form of a table. 
  In the dropdown menu the user can sellect by which parameter they wants to filter the books list and under the menu there is a textbox to specify the parameter - title, author, publisher and etc.
  The second button allows the user to see the full list of the books.
  
  In the toolstrip menu, the element "For librarian" opens the second form - there the librarian can specify the book's parameters and add the new book into the list. After that, the form automatically closes.
  
  Back to the first form - the third toolstrip menu item opens the third form where user can reserve or borrow the book they wants to have. They needs to specify all the parameters of the book and choose one of the buttons to either reserve or borrow the book. After that, the message appears which informs whether the action was completed successfully or not (the book was not found or isn't free). 
  
Toolstrip menu item "Return book" allows the librarian to register the returning book and if one is not found, then it is registered as new in the list.
