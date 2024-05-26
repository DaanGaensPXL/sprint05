@page
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <h1 class="display-4">Welcome</h1>
    <p>Use your Active Directory credentials to log in.</p>
    <form method="post" asp-page-handler="Login">
        <div>
            <label for="username">Username</label>
            <input type="text" id="username" name="username" required />
        </div>
        <div>
            <label for="password">Password</label>
            <input type="password" id="password" name="password" required />
        </div>
        <button type="submit">Login</button>
    </form>
    <p id="message">@Model.Message</p>
</div>
