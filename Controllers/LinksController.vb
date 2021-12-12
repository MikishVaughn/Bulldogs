Public Class LinksController
    Inherits System.Web.Mvc.Controller

    Function WebArtJPG() As ActionResult
        ViewData("Message") = "WebArtJPG"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Website JPG Artwork"
        Return View()
    End Function

End Class
