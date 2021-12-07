Public Class InfoController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "About"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Bulldog Youth Wrestling Club")
        Return View(About)
    End Function
    Function About() As ActionResult
        ViewData("Message") = "About"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Bulldog Youth Wrestling Club")
        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Contact"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Message")
        Return View()
    End Function
    Function TOS() As ActionResult
        ViewData("Message") = "TOS"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Message")
        Return View()
    End Function
    Function Privacy() As ActionResult
        ViewData("Message") = "Privacy"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Message")
        Return View()
    End Function
    Function Events() As ActionResult
        ViewData("Message") = "Events"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Message")
        Return View()
    End Function
    Function Schedule() As ActionResult
        ViewData("Message") = "Schedule"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Message")
        Return View()
    End Function
    Function Fundraise() As ActionResult
        ViewData("Message") = "Fundraise"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Message")
        Return View()
    End Function
    Function Features() As ActionResult
        ViewData("Message") = "Features"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Message")
        Return View()
    End Function
    Function TrackWrestling() As ActionResult
        ViewData("Message") = "TrackWrestling"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Message")
        Return View()
    End Function

End Class
