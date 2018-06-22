using System;
using System.Reflection;

namespace MVC_Angular_Material_6_Boilerplate.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}