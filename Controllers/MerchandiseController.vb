Public Class MerchandiseController
    Inherits System.Web.Mvc.Controller
    Function Store() As ActionResult
        ViewData("Message") = "Store"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Message")
        Return View()
    End Function


End Class
