#pragma checksum "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97aad5f03e0d51e17ef73ae1244ca7761ef1e9d2"
// <auto-generated/>
#pragma warning disable 1591
namespace bikeservice.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/borakasmer/Projects/bikeservice/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/borakasmer/Projects/bikeservice/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/borakasmer/Projects/bikeservice/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/borakasmer/Projects/bikeservice/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/borakasmer/Projects/bikeservice/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/borakasmer/Projects/bikeservice/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/borakasmer/Projects/bikeservice/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/borakasmer/Projects/bikeservice/_Imports.razor"
using bikeservice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/borakasmer/Projects/bikeservice/_Imports.razor"
using bikeservice.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
using bikeservice.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
using FluentValidation;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bikeservice")]
    public class BikeService : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Coder Bike Service</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>Customer Service Records</p>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                 customer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                                          SaveCustomer

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenComponent<FluentValidation.FluentValidator<CustomerValidator>>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\n\n    ");
                __builder2.AddMarkupContent(9, "<h3>Customer Name</h3>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "placeholder", "First name");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                                                     customer.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.Name = __value, customer.Name))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "placeholder", "Last name");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                                                    customer.Surname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.Surname = __value, customer.Surname))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.Surname));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\n    ");
                __Blazor.bikeservice.Pages.BikeService.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 15 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                              () => customer.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(24, "\n    ");
                __Blazor.bikeservice.Pages.BikeService.TypeInference.CreateValidationMessage_1(__builder2, 25, 26, 
#nullable restore
#line 16 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                              () => customer.Surname

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(27, "\n\n    ");
                __builder2.AddMarkupContent(28, "<h3>Customer Bike</h3>\n    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddMarkupContent(30, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "placeholder", "Model");
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                                                    customer.Bike.Model

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.Bike.Model = __value, customer.Bike.Model))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.Bike.Model));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\n        ");
                __Blazor.bikeservice.Pages.BikeService.TypeInference.CreateValidationMessage_2(__builder2, 37, 38, 
#nullable restore
#line 21 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                                  () => customer.Bike.Model

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(39, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddMarkupContent(42, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                __builder2.AddAttribute(44, "placeholder", "Year");
                __builder2.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                                                   customer.Bike.Year

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.Bike.Year = __value, customer.Bike.Year))));
                __builder2.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.Bike.Year));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\n        ");
                __Blazor.bikeservice.Pages.BikeService.TypeInference.CreateValidationMessage_3(__builder2, 49, 50, 
#nullable restore
#line 25 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                                  () => customer.Bike.Year

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(51, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddMarkupContent(54, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(55);
                __builder2.AddAttribute(56, "placeholder", "Seri No");
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                                                      customer.Bike.Serino

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.Bike.Serino = __value, customer.Bike.Serino))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.Bike.Serino));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\n        ");
                __Blazor.bikeservice.Pages.BikeService.TypeInference.CreateValidationMessage_4(__builder2, 61, 62, 
#nullable restore
#line 29 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                                  () => customer.Bike.Serino

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(63, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\n\n    ");
                __builder2.OpenElement(65, "h3");
                __builder2.AddMarkupContent(66, "\n       Service List        \n        [");
                __builder2.OpenElement(67, "a");
                __builder2.AddAttribute(68, "href", "javascript: void(0)");
                __builder2.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                                                  AddService

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(70, "Add Service Record");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "]\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\n    ");
                __Blazor.bikeservice.Pages.BikeService.TypeInference.CreateValidationMessage_5(__builder2, 73, 74, 
#nullable restore
#line 36 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                              () => customer.Services

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(75, "\n\n");
#nullable restore
#line 38 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
     foreach (var service in customer.Services)
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(76, "        ");
                __builder2.OpenElement(77, "p");
                __builder2.AddMarkupContent(78, "\n            ");
                __Blazor.bikeservice.Pages.BikeService.TypeInference.CreateInputSelect_6(__builder2, 79, 80, 
#nullable restore
#line 41 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                                      service.ServiceType

#line default
#line hidden
#nullable disable
                , 81, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => service.ServiceType = __value, service.ServiceType)), 82, () => service.ServiceType, 83, (__builder3) => {
                    __builder3.AddMarkupContent(84, "\n                ");
                    __builder3.OpenElement(85, "option");
                    __builder3.AddAttribute(86, "value", 
#nullable restore
#line 42 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                                Service.Type.BinBakım

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(87, "Bin Bakım");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(88, "\n                ");
                    __builder3.OpenElement(89, "option");
                    __builder3.AddAttribute(90, "value", 
#nullable restore
#line 43 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                                Service.Type.AltıBinBakım

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(91, "AltıBin Bakım");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(92, "\n                ");
                    __builder3.OpenElement(93, "option");
                    __builder3.AddAttribute(94, "value", 
#nullable restore
#line 44 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                                Service.Type.OnikiBinBakım

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(95, "OnikiBin Bakım");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(96, "                \n            ");
                }
                );
                __builder2.AddMarkupContent(97, "\n\n");
#nullable restore
#line 47 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
             if (service.ServiceType == Service.Type.OnikiBinBakım)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(98, "                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(99);
                __builder2.AddAttribute(100, "placeholder", "Seri No");
                __builder2.AddAttribute(101, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                                                              service.SeriNo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => service.SeriNo = __value, service.SeriNo))));
                __builder2.AddAttribute(103, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => service.SeriNo));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\n");
#nullable restore
#line 50 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(105, "                ");
                __builder2.AddMarkupContent(106, "<span>You don\'t need Service Number!</span>\n");
#nullable restore
#line 54 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(107, "\n            ");
                __builder2.OpenElement(108, "button");
                __builder2.AddAttribute(109, "type", "button");
                __builder2.AddAttribute(110, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                                              () => customer.Services.Remove(service)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(111, "Remove");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\n\n            ");
                __Blazor.bikeservice.Pages.BikeService.TypeInference.CreateValidationMessage_7(__builder2, 113, 114, 
#nullable restore
#line 58 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
                                      () => service.SeriNo

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(115, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\n");
#nullable restore
#line 60 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(117, "\n    ");
                __builder2.AddMarkupContent(118, "<p><button type=\"submit\">Submit</button></p>\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "/Users/borakasmer/Projects/bikeservice/Pages/BikeService.razor"
       
    private Customer customer = new Customer();

    void AddService()
    {
        customer.Services.Add(new Service());
    }

    void SaveCustomer()
    {
        Console.WriteLine("TODO: Actually do something with the valid data");
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.bikeservice.Pages.BikeService
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591