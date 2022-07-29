Public Class SiteHelpers

    ' ' GetSiteInfo      
    '********************
    '
    ' Get Site Info - This is where site info is changed as needed.
    '
    <AllowAnonymous>
    Public Shared Function GetSiteInfo(AttributeName As String) As String

        Dim siteURL As String = LCase(RootUrl())

        ' Site Name
        If AttributeName = "SiteName" Then
            Return "Southern Illinois Bulldogs"
        End If
        If AttributeName = "SiteNameShort" Then
            Return "Bulldogs Wrestling"
        End If

        ' Site Description
        If AttributeName = "SiteDescription" Then
            Return "This web site is dedicated to the Southern Illinois Bulldogs Wrestlers!"
        End If

        ' Site URL
        If AttributeName = "SiteURL" Then
            Return "https://SouthernIllinoisBulldogs.com"
        End If

        ' Site Contact
        If AttributeName = "SiteContact" Then
            Return "Butch Schloemann"
        End If

        ' Site Address
        If AttributeName = "Address1" Then
            Return "1107 s. Main st"
        End If
        If AttributeName = "Address2" Then
            Return "Red Bud, Illinois 62278"
        End If

        ' Phone
        If AttributeName = "Phone1" Then
            Return "314-712-3403"
        End If

        ' Site Email
        If AttributeName = "SiteEmailContact" Then
            Return "waterloowrestling@yahoo.com"
        End If

        ' Site Sales and Support
        If AttributeName = "SiteEmailSales" Then
            Return "Sales@example.com"
        End If
        If AttributeName = "SiteEmailSupport" Then
            Return "Info@example.com"
        End If

        ' Facebook Page
        If AttributeName = "SiteFacebookPageURL" Then
            Return "https://www.facebook.com/jessischloemann/"
        End If

        ' Google Maps Location
        If AttributeName = "SiteGoogleMapURL" Then
            Return "https://www.google.com/maps/place/1107+S+Main+St,+Red+Bud,+IL+62278/@38.201692,-89.9953916,536m/data=!3m1!1e3!4m5!3m4!1s0x88762764bbdbc3e5:0xebb720ff8b455ab2!8m2!3d38.2014852!4d-89.994499"
        End If

        ' Site Images
        If AttributeName = "BigLogo" Then
            Return "/Content/Catagories/Svg/BD-Body-[New].svg"
        End If
        If AttributeName = "SmallLogo" Then
            Return "/Content/Catagories/Svg/BD-Body-Head-Master.svg"
        End If
        'If AttributeName = "PageImage_About" Then
        '    Return "https:/SouthernIllinoisBulldogs/Content/Catagories/PageImages/900x800-image-03.jpg"
        'End If
        If AttributeName = "LinkShare" Then
            Return "/Content/Catagories/LinkShares/BD-Logo-001.jpg"
        End If

        ' Site Designer
        If AttributeName = "SiteDesigner" Then
            Return "The Mikish Group"
        End If
        If AttributeName = "SiteEmailDesigner" Then
            Return "Mikish.Vaughn@Gmail.com"
        End If
        If AttributeName = "SiteDesignerURL" Then
            Return "https://mikish.com"
        End If
        If AttributeName = "SiteDesignerLogo" Then
            Return "https:/SouthernIllinoisBulldogs/Content/Catagories/Svg/BlueSun.svg"
        End If

        'If we make it here then there was a coding failure!
        Return "Oops!" ' :-(

    End Function

    ' ' RootURL()        
    '********************
    '
    ' Used to return the Root URL to determine the site address and therefore identity.
    '
    <AllowAnonymous>
    Public Shared Function RootUrl() As String
        Return HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/")
    End Function

    ' ' ImageCount() 
    '********************
    '
    ' Returns the image count in an image folder.
    '
    <AllowAnonymous>
    Public Shared Function ImageCount(folder As String, extension As String) As Integer

        Dim Count As Integer = 1
        Try
            If HttpContext.Current.Request.IsLocal Then
                Count = IO.Directory.GetFiles("D:\Projects\Repos\Bulldogs\Content\Catagories\" + folder + "\", "*" + extension).Length()
            Else
                Count = IO.Directory.GetFiles("h:\root\home\mikish-001\www\SIBulldogs\Content\Catagories\" + folder + "\", "*" + extension).Length()
            End If
        Catch ex As Exception
            MsgBox("Image Directory Not Found", MsgBoxStyle.Critical)
            Return Count
        End Try

        Return Count

    End Function

    ' FileCount() ' Unused at this time
    '********************
    '
    ' Returns the file count in a Content folder.
    '
    '<AllowAnonymous>
    'Public Shared Function Filelist(folder As String, extension As String) As String  ' Unused at this time
    '    If HttpContext.Current.Request.IsLocal Then
    '        folder = "d:\projects\repos\bulldogs\content\catagories\carousel\" + folder
    '    Else
    '        folder = "h:\root\home\mikish-001\www\subs\images\content\images\Site\carousel\" + folder
    '    End If

    '    Dim htmlstring As String = ""
    '    Try

    '        Dim pointer As Integer = 1
    '        Dim files As Array = IO.Directory.GetFiles(folder, "*." + extension)

    '        Dim count = files.Length()
    '        If count > 0 Then
    '            Do While pointer <= count
    '                htmlstring += "<a href='' target='_blank'><img Class='img-thumbnail img-fluid mb-1 mb-lg-0 p-0' src='D:\projects\repos\bulldogs\content\Catagory\Gallery\pictures\01\000001.jpg' alt ='Image'></a>"

    '                pointer += 1
    '            Loop
    '        End If


    '    Catch ex As Exception
    '        MsgBox("Count Array Failed: " + folder, MsgBoxStyle.Critical)
    '        Return ""
    '    End Try

    '    Return htmlstring

    'End Function

    ' GetImageLocation 
    '********************
    '
    <AllowAnonymous>
    Public Shared Function GetImageLocation() As String

        Dim ImageLocation As String = "/Content/Catagories/"
        If HttpContext.Current.Request.IsLocal Then
            ImageLocation = "/Content/Catagories/"
        End If

        Return ImageLocation

    End Function

    ' Overrides   
    '********************
    '
    ' Additional Class Functions
    '
    Public Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
    Public Overrides Function Equals(obj As Object) As Boolean
        Return MyBase.Equals(obj)
    End Function
    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class