Public Class GalleryController
    Inherits System.Web.Mvc.Controller
    Function Index() As ActionResult
        ViewData("Message") = "Gallery"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Message")
        Return View(Gallery)
    End Function
    Function Gallery() As ActionResult
        ViewData("Message") = "Gallery"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Message")
        Return View()
    End Function    
    Function WebArtSVG() As ActionResult
        ViewData("Message") = "WebArtSVG"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Website SVG Artwork"
        Return View()
    End Function
    Function WebArtJPG() As ActionResult
        ViewData("Message") = "WebArtJPG"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Website JPG Artwork"
        Return View()
    End Function
    Function WebArtPNG() As ActionResult
        ViewData("Message") = "WebArtPNG"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Website PNG Artwork"
        Return View()
    End Function
    Function WebArtEPS() As ActionResult
        ViewData("Message") = "WebArtEPS"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Website EPS Masters"
        Return View()
    End Function
    Function WebArtZIP() As ActionResult
        ViewData("Message") = "WebArtZIP"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Website Artwork Zip Files"
        Return View()
    End Function
    Function Pictures01() As ActionResult
        ViewData("Message") = "Pictures01"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Pictures - Group 01"
        Return View()
    End Function
    Function Pictures02() As ActionResult
        ViewData("Message") = "Pictures02"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Pictures - Group 02"
        Return View()
    End Function
    Function Pictures03() As ActionResult
        ViewData("Message") = "Pictures03"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Pictures - Group 03"
        Return View()
    End Function
    Function Pictures04() As ActionResult
        ViewData("Message") = "Pictures04"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Pictures - Group 04"
        Return View()
    End Function
    Function Pictures05() As ActionResult
        ViewData("Message") = "Pictures05"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Pictures - Group 05"
        Return View()
    End Function
    Function Pictures06() As ActionResult
        ViewData("Message") = "Pictures06"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Pictures - Group 06"
        Return View()
    End Function
    Function Pictures07() As ActionResult
        ViewData("Message") = "Pictures07"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Pictures - Group 07"
        Return View()
    End Function
    Function Pictures08() As ActionResult
        ViewData("Message") = "Pictures08"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Pictures - Group 08"
        Return View()
    End Function
    Function Pictures09() As ActionResult
        ViewData("Message") = "Pictures09"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Pictures - Group 09"
        Return View()
    End Function
    Function Pictures10() As ActionResult
        ViewData("Message") = "Pictures10"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Pictures - Group 10"
        Return View()
    End Function
    Function Videos01() As ActionResult
        ViewData("Message") = "Videos01"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Videos - Group 01"
        Return View()
    End Function
    Function Videos02() As ActionResult
        ViewData("Message") = "Videos02"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Videos - Group 02"
        Return View()
    End Function
    Function Videos03() As ActionResult
        ViewData("Message") = "Videos03"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Videos - Group 03"
        Return View()
    End Function
    Function Videos04() As ActionResult
        ViewData("Message") = "Videos04"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Videos - Group 04"
        Return View()
    End Function
    Function Videos05() As ActionResult
        ViewData("Message") = "Videos05"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Videos - Group 05"
        Return View()
    End Function
    Function Videos06() As ActionResult
        ViewData("Message") = "Videos06"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Videos - Group 06"
        Return View()
    End Function
    Function Videos07() As ActionResult
        ViewData("Message") = "Videos07"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Videos - Group 07"
        Return View()
    End Function
    Function Videos08() As ActionResult
        ViewData("Message") = "Videos08"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Videos - Group 08"
        Return View()
    End Function
    Function Videos09() As ActionResult
        ViewData("Message") = "Videos09"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Videos - Group 09"
        Return View()
    End Function
    Function Videos10() As ActionResult
        ViewData("Message") = "Videos10"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = "Videos - Group 10"
        Return View()
    End Function

End Class
