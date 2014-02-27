<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <menu type ="toolbar">

        <li>
            <menu label="file">
                <button type="button" onclick="">HOME</button>
                <button type="button" onclick="">CONTAC</button>
                <button type="button" onclick="">RECOMEND</button>

            </menu>
       </li>
    </menu>


    @RenderBody()
    @Scripts.Render("~/bundles/jquery")
    @RenderSection("scripts", required:=False)
    
    


</body>
</html>
