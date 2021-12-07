@Imports Microsoft.AspNet.Identity

<style>
    li {
        text-decoration:none;
        color: black;
        padding: 4px;
    }
</style>

@If Request.IsAuthenticated
    @Using Html.BeginForm("LogOff", "Account", FormMethod.Post, New With { .id = "logoutForm", .class = "navbar-right" })
        @Html.AntiForgeryToken()
        @<ul class="nav navbar-nav navbar-right">            
            <li><a class="nav-link" href="Manage/Index">Manage</a></li>            
            <li><a href="javascript:document.getElementById('logoutForm').submit()">Log off</a></li>
        </ul>
    End Using
Else
    @<ul class="nav navbar-nav navbar-right">
    <li><a class="nav-link" href="~/Account/Register">Register</a></li>
    <li><a class="nav-link" href="~/Account/Login">Log In</a></li>
</ul>
End If

