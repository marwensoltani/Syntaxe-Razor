#pragma checksum "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "347c49a33fde3c53b888db8a8e6c06749875f64c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Syntaxe_Razor.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Syntaxe_Razor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\_ViewImports.cshtml"
using Syntaxe_Razor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"347c49a33fde3c53b888db8a8e6c06749875f64c", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"823f5e2c8caf1f76ce9db81a6d4a87562028a5c0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Syntaxe Razor</h1>\r\n    <p>");
#nullable restore
#line 9 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
  Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <!-- Fragment Razor-->\r\n");
#nullable restore
#line 11 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
      
        var nom = "BEN TECH PRO TV";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Bienvenue sur la cha??ne YouTube: ");
#nullable restore
#line 14 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                                   Write(nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 15 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
      
        nom = "Karim Ben Romdhane";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Bonjour ");
#nullable restore
#line 18 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
          Write(nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <!-- Fragment Razor : Calcul Arithm??tique -->\r\n");
#nullable restore
#line 20 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
      
        var x = 6;
        var y = 4;
        var somme = x + y;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>la somme de x + y = ");
#nullable restore
#line 24 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                            Write(x + y);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h2>la somme de x + y = ");
#nullable restore
#line 25 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                           Write(somme);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            WriteLiteral("</div>\r\n<div class=\"text-center\">\r\n    <!-- Fragment Razor : IF-->\r\n");
#nullable restore
#line 30 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
       
        var site = "Youtube";
        var chaine = "BEND TECH PRO TV";
        if (site == "Youtube" && chaine == "BEN TECH PRO TV")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2> Vous ??tes sur la cha??ne d\'enseignement universitaire ?? distance.</h2>\r\n");
#nullable restore
#line 36 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>Cherchez la cha??ne \"BEN TECH PRO TV\" sur Youtube.</h2>\r\n");
#nullable restore
#line 40 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"text-center\">\r\n    <!-- Fragment Razor: foreach -->\r\n");
#nullable restore
#line 45 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
       
        string[] villes = { "Bizerte", "Ras Jebel", "Sousse", "Tunis" };
        foreach (var ville in villes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>");
#nullable restore
#line 49 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
           Write(ville);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 50 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"text-center\">\r\n    <table border=\"1\">\r\n        <tr>\r\n            <!-- fragment Razor boucle for-->\r\n            <td>\r\n");
#nullable restore
#line 58 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                  
                    //boucle for

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <H2>boucle for</H2>\r\n");
#nullable restore
#line 61 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                    for (int i = 0; i < villes.Length; i++)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                   Write(villes[i]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                                  ;

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 64 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 68 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                  
                    //boucle do while

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <H2>boucle do while</H2>\r\n");
#nullable restore
#line 71 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                    var compteur = 0;
                    do
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                   Write(villes[compteur]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                                         ;

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 75 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                        compteur++;
                    } while (compteur < villes.Length);
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 80 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                  
                    //boucle  while

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <H2>boucle while</H2>\r\n");
#nullable restore
#line 83 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                    var cw = 0;
                    while(cw < villes.Length)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                   Write(villes[cw]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                                   ;

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 87 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                        cw++;
                    } 
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n\r\n    </table>\r\n</div>\r\n<div class=\"text-center\">\r\n    <!-- Fragment Razor: le fonctions-->\r\n");
            WriteLiteral("\r\n\r\n    <h2> Aujourd\'hui est le ");
#nullable restore
#line 113 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                       Write(Aujourdhui());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h2> (7 x 4) = ");
#nullable restore
#line 114 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
              Write(multiplier(7,4));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h2>Ma cha??ne YouTube est ");
#nullable restore
#line 115 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                         Write(MaChaine());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "C:\Users\karou\source\repos\Syntaxe Razor\Syntaxe Razor\Pages\Index.cshtml"
                
        DateTime Aujourdhui()
        {
            return DateTime.Now;
        }
        int multiplier(int x, int y)
        {
            return x * y;
        }
        String MaChaine()
        {
            return "BEN TECH PRO TV";
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
