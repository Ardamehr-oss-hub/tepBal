#pragma checksum "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "370d8c3ae011ba588ee098da41d49ff586acbe50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ResultData), @"mvc.1.0.view", @"/Views/Home/ResultData.cshtml")]
namespace AspNetCore
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
#line 1 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"370d8c3ae011ba588ee098da41d49ff586acbe50", @"/Views/Home/ResultData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ResultData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
  
    ViewData["Title"] = "Результат";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""text-center"">
        <h1 class=""display-4""><b>Результат</b></h1>
        <table border=""1"" align=""center"" valign=""bottom"">
            <tr>
                <td bgcolor=""#7edbdd""><h3>Название</h3></td>
                <td bgcolor=""#7edbdd""><h3>Значение</h3></td>
                <td bgcolor=""#7edbdd""><h3>Измерение</h3></td>
            </tr>
            <tr>
                <td> Химическая теплота топлива </td>
                <td>");
#nullable restore
#line 17 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.Qx);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>кДж</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Средное значения температуры за третий период сушки</td>\r\n                <td>");
#nullable restore
#line 22 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.t2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><sup><small>0</small></sup>С</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Средное значения температуры за второй период сушки</td>\r\n                <td>");
#nullable restore
#line 27 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.t1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><sup><small>0</small></sup>С</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Средное значения температуры за первый период сушки</td>\r\n                <td>");
#nullable restore
#line 32 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.t0);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><sup><small>0</small></sup>С</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Влажность материала в начеле сушки</td>\r\n                <td>");
#nullable restore
#line 37 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.W1c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>кДж</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Влажность материала в конце сушки</td>\r\n                <td>");
#nullable restore
#line 42 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.W2c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>кДж</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Температура массы сущимого материала в конце</td>\r\n                <td>");
#nullable restore
#line 47 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.tmm2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><sup><small>0</small></sup>С</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Расчет статьи</td>\r\n                <td>");
#nullable restore
#line 52 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.Q1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>кДж</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Разбавление первычных продуктов сгорания воздухом в количестве xв</td>\r\n                <td>");
#nullable restore
#line 57 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.q2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>кДж</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Потери теплоты с уходящими газами</td>\r\n                <td>");
#nullable restore
#line 62 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.Q2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>кДж</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Химический недожог</td>\r\n                <td>");
#nullable restore
#line 67 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.Q3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>кДж</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Потери теплоты на нагреве приспомобленний и теплопроводностью через стенки</td>\r\n                <td>");
#nullable restore
#line 72 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.Q5np);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>кДж</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Средное значение температуры между первим и вторим периодом сушки</td>\r\n                <td>");
#nullable restore
#line 77 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.tct1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><sup><small>0</small></sup>С</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Средное значение температуры между третим и вторим периодом сушки</td>\r\n                <td>");
#nullable restore
#line 82 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.tct2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><sup><small>0</small></sup>С</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <td>Плотность телового потока</td>\r\n                <td>");
#nullable restore
#line 88 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.q5t);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>кДж</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <td>Толщину стенок камеры</td>\r\n                <td>");
#nullable restore
#line 94 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.Scm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>м</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Средняя поверхность стеной</td>\r\n                <td>");
#nullable restore
#line 99 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.F22);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>м<sup><small>2</small></sup></td>\r\n            </tr>\r\n            <tr>\r\n                <td>Потери теплоты теплопроводностью через стенку сушильной печи</td>\r\n                <td>");
#nullable restore
#line 104 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.Q5tct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>кДж</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Потери теплоты через свод</td>\r\n                <td>");
#nullable restore
#line 109 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.Q5tcv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>кДж</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Потери теплоты через двери сушильной камеры</td>\r\n                <td>");
#nullable restore
#line 114 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.Q5tdv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>кДж</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Общие потери теплоты теплопроводностью</td>\r\n                <td>");
#nullable restore
#line 119 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.Q5trp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>кДж</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Покрытие потерь топлоты теплопроводностью</td>\r\n                <td>");
#nullable restore
#line 124 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.Q5rp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>кДж</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Потери теплоты топкой</td>\r\n                <td>");
#nullable restore
#line 129 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.Q5top);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>кДж</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Аккумуляция теплоты стенками рабочего пространва</td>\r\n                <td>");
#nullable restore
#line 134 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.tctnach);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><sup><small>0</small></sup>С</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Средние изменинея температур внутренней поверхности стенок</td>\r\n                <td>");
#nullable restore
#line 139 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.crtct1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><sup><small>0</small></sup>С</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Температура за время τ2</td>\r\n                <td>");
#nullable restore
#line 144 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.ttst2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><sup><small>0</small></sup>С</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Температура нагрева стенки</td>\r\n                <td>");
#nullable restore
#line 149 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.tctnag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><sup><small>0</small></sup>С</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Температура стенки охложденная</td>\r\n                <td>");
#nullable restore
#line 154 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.tctoxl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><sup><small>0</small></sup>С</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Время τ\'</td>\r\n                <td>");
#nullable restore
#line 159 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.tt1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>с</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Время τ\'\'</td>\r\n                <td>");
#nullable restore
#line 164 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.tt2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>с</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Сумма внутренней поверхности стенки</td>\r\n                <td>");
#nullable restore
#line 169 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.Fcm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>м<sup><small>2</small></sup></td>\r\n            </tr>\r\n            <tr>\r\n                <td>Аккумуляция теплоты стенки печи при циклических калибаний температуры</td>\r\n                <td>");
#nullable restore
#line 174 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.Qv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>кДж</td>\r\n            </tr>\r\n");
            WriteLiteral("            <tr>\r\n                <td>Объем одной  топки</td>\r\n                <td>");
#nullable restore
#line 184 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.Vtop);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>м<sup><small>3</small></sup></td>\r\n            </tr>\r\n            <tr>\r\n                <td>Масса исправленной из изделий влаги</td>\r\n                <td>");
#nullable restore
#line 189 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
               Write(Model.Gvl);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                <td>кг</td>
            </tr>
        </table>
        <div class=""text-center"">
            <h5><b>Топливо</b></h5>
           
                <table border=""1"" align=""center"" valign=""bottom"">
                    <tr>
                        <td>Расход топливо в секунду</td>
                        <td>");
#nullable restore
#line 199 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
                       Write(Model.tsk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>м<sup><small>3</small></sup>/с</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Всего типливо расходуется</td>\r\n                        <td>");
#nullable restore
#line 204 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
                       Write(Model.topl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>м<sup><small>3</small></sup></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Коэффицент полезного действия</td>\r\n                        <td>");
#nullable restore
#line 209 "D:\3 курс ИНМИТ\3 курс 1 семестр\флешка\3курс\WebApplication1\WebApplication1\Views\Home\ResultData.cshtml"
                       Write(Model.kpd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>%</td>\r\n                    </tr>\r\n                </table>\r\n             \r\n        </div>\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
