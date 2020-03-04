Option Strict On

''' <summary>
''' Last Modified By:   Kyle Chapman
''' Original Date:      Mar 2, 2020
''' Last Modified Date: Mar 4, 2020
''' Project Name:       CustomerViewer
''' Description:
'''     Using the existing Customer class, this is a simple form designed to toggle through a list of customers, strictly to view their info.
''' </summary>
Public Class CustomerViewer

    Private customerList As New List(Of Customer)   ' collection of all the customers in the list
    Private currentIndex As Integer = 0             ' represents the current selected customer

    ''' <summary>
    ''' When the form loads, instantiate some customers and add them 
    ''' to a list so they can be viewed later.
    ''' </summary>
    Private Sub CustomerViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Declare and instantiate five new customer objects
        ' You are going to be asked to change some of these values
        Dim kyle = New Customer("Mr.", "Kyle", "Chapman", True)
        Dim yourNameHere = New Customer("", "Your", "Name", True)
        Dim someoneElse = New Customer("", "Someone's", "Name", True)
        Dim aFourthPerson = New Customer("", "Fourth Person's", "Name", True)
        Dim everyoneIsImportant = New Customer("", "Everyone's", "Important", False)

        ' ** IN-CLASS EXERCISE 4, part 4 of 4 **
        ' After the Next and Previous buttons are working, adjust the Customer objects above
        ' Change the yourNameHere object so that its details match yourself
        ' Change the someoneElse object so that its details match a person you're sitting beside
        ' Add a sixth customer with details of your choice and ensure it's added to the list
        ' Feel free to add more customers if you like

        ' Add all created customer objects to the list
        customerList.Add(kyle)
        customerList.Add(yourNameHere)
        customerList.Add(everyoneIsImportant)
        customerList.Add(aFourthPerson)
        customerList.Add(someoneElse)

        ' Call ViewCustomer and display the first customer object - should be index 0
        ViewCustomer(currentIndex)

    End Sub

    ''' <summary>
    ''' Shows the previous customer in the list, populating all fields 
    ''' with information related to the previous customer; displays an 
    ''' error message if there are no prior customers in the list
    ''' </summary>
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        ' ** IN-CLASS EXERCISE 4, part 3 of 4 **
        ' After ViewCustomer() is working - or at least testable
        ' Get this button working
        ' This will not be shown in class but will be very similar to btnNext_Click(), below

    End Sub

    ''' <summary>
    ''' Shows the next customer in the list, populating all fields 
    ''' with information related to the next customer; displays an 
    ''' error message if there are no more customers in the list
    ''' </summary>
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        ' ** IN-CLASS EXERCISE 4, part 2 of 4 **
        ' After ViewCustomer() is working - or at least testable
        ' Get this button working
        ' This part will be 100% shown in class

    End Sub

    ''' <summary>
    ''' Closes the application
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Attempt to display a customer from the customerList with a key 
    ''' value matching the argument passed in.
    ''' </summary>
    ''' <param name="listIndex">An integer value representing the index of the customer object</param>
    ''' <returns>True if successful, False if not</returns>
    Private Function ViewCustomer(listIndex As Integer) As Boolean

        ' ** IN-CLASS EXERCISE 4, part 1 of 4 **
        ' Get this function working
        ' This part will be 100% shown in class

        ' If the current listIndex is in range

        ' Populate the various fields with the relevant customer info

        ' In the event that this was successful, Return True

        ' In the event that this went out-of-bounds, Return False
        Return False

    End Function

    ' ** IN-CLASS EXERCISE 4 BONUS STUFF **
    ' If you'd like a bonus mark on In-Class Exercise 4 so that you can earn 3.5 / 3
    ' do all of the following:
    ' - Add a working First button to the form that goes to the first Customer in the list
    ' - Add a working Last button to the form that goes to the last Customer in the list
    ' - Make it so that the Previous and Next buttons are Enabled/Disabled at appropriate times

End Class
