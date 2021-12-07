@ModelType ChangePasswordViewModel
@Code
    ViewBag.Title = "Change Password"
End Code

<h2>@ViewBag.Title</h2>

@Using Html.BeginForm("ChangePassword", "Manage", FormMethod.Post, New With { .class = "form-horizontal", .role = "form" })
    @Html.AntiForgeryToken()
    
    @<text>
    <h4>Change Password Form</h4>
    <hr />
    @Html.ValidationSummary("", New With { .class = "text-danger" })
    <div class="form-group row py-2">
        @Html.LabelFor(Function(m) m.OldPassword, New With {.class = "col-md-2 control-label py-2"})
        <div class="col-md-10">
            @Html.PasswordFor(Function(m) m.OldPassword, New With {.class = "form-control py-2"})
        </div>
    </div>
    <div class="form-group row py-2">
        @Html.LabelFor(Function(m) m.NewPassword, New With {.class = "col-md-2 control-label py-2"})
        <div class="col-md-10">
            @Html.PasswordFor(Function(m) m.NewPassword, New With {.class = "form-control py-2"})
        </div>
    </div>
    <div class="form-group row py-2">
        @Html.LabelFor(Function(m) m.ConfirmPassword, New With {.class = "col-md-2 control-label py-2"})
        <div class="col-md-10">
            @Html.PasswordFor(Function(m) m.ConfirmPassword, New With {.class = "form-control py-2"})
        </div>
    </div>
    <div class="form-group row py-2">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="Change password" class="btn btn-default bg-dark text-light mt-5" />
        </div>
    </div>
    </text>
End Using

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section