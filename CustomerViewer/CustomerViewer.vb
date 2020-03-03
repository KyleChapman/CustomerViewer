Option Strict On

''' <summary>
''' Last Modified By:   Kyle Chapman
''' Original Date:      Mar 3, 2020
''' Last Modified Date: Mar 4, 2020
''' Project Name:       CustomerViewer
''' Description:
'''     Using the existing Customer class, this is a simple form designed to toggle through a list of customers, strictly to view their info.
''' </summary>
Public Class CustomerViewer

    Private customerList As New List(Of Customer)  ' collection of all the customers in the list
    Private currentIndex As Integer = 1            ' represents the current selected customer

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

        ' Add the five new customer objects to the list
        customerList.Add(kyle)
        customerList.Add(yourNameHere)
        customerList.Add(everyoneIsImportant)
        customerList.Add(aFourthPerson)
        customerList.Add(someoneElse)

        ' Call ViewCustomer and display the first customer object
        ViewCustomer(currentIndex)

    End Sub

    ''' <summary>
    ''' Shows the previous customer in the list, populating all fields 
    ''' with information related to the previous customer; displays an 
    ''' error message if there are no prior customers in the list
    ''' </summary>
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

    End Sub

    ''' <summary>
    ''' Shows the next customer in the list, populating all fields 
    ''' with information related to the next customer; displays an 
    ''' error message if there are no more customers in the list
    ''' </summary>
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

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
        Return True
    End Function

End Class
