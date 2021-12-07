@ModelType LoginViewModel
@Code
    ViewBag.Title = "Sign in"
End Code

<h2>@ViewBag.Title</h2>

<div class="row rounded mb-3">
    <div class="col-md-8">

        <section id="loginForm">
            @Using Html.BeginForm("Login", "Account", New With {.ReturnUrl = ViewBag.ReturnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})

                @Html.AntiForgeryToken()

                @<text>
                    <div class="mb-3 pb-3">
                        <h4>Use a local account to sign in.</h4>
                        <hr />

                        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                        <div class="form-group row py-2">
                            @Html.LabelFor(Function(m) m.Email, New With {.class = "col-md-2 control-label py-2"})
                            <div class="col-md-10">
                                @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control"})
                                @Html.ValidationMessageFor(Function(m) m.Email, "", New With {.class = "text-danger"})
                            </div>
                        </div>
                        <div class="form-group row py-2">
                            @Html.LabelFor(Function(m) m.Password, New With {.class = "col-md-2 control-label py-2"})
                            <div class="col-md-10">
                                @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
                                @Html.ValidationMessageFor(Function(m) m.Password, "", New With {.class = "text-danger"})
                            </div>
                        </div>
                        <div class="form-group row py-2">
                            <div class="col-md-offset-2 col-md-10">
                                <div class="checkbox">
                                    @Html.CheckBoxFor(Function(m) m.RememberMe)
                                    @Html.LabelFor(Function(m) m.RememberMe)
                                </div>
                            </div>
                        </div>
                        <div class="form-group row py-2">
                            <div class="col-md-offset-2 col-md-10">
                                <input type="submit" value="Log in" class="btn btn-default bg-dark text-light mt-5" />
                            </div>
                        </div>

                        @*<p>
                            @Html.ActionLink("Register as a new user", "Register")
                        </p>*@
                        @* Enable this once you have account confirmation enabled for password reset functionality
                        <p>
                            @Html.ActionLink("Forgot your password?", "ForgotPassword")
                        </p>*@
                    </div>

                </text>
            End Using
        </section>

    </div>
    <div class="col-md-4">
        <section id="socialLoginForm">
            @Html.Partial("_ExternalLoginsListPartial", New ExternalLoginListViewModel With {.ReturnUrl = ViewBag.ReturnUrl})
        </section>
    </div>
</div>
@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
