﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable enable

namespace Microsoft.EntityFrameworkCore.NativeAotTests.CompiledModels
{
    public partial class NativeAotContextModel
    {
        partial void Initialize()
        {
            var user = UserEntityType.Create(this);

            UserEntityType.CreateAnnotations(user);

            AddAnnotation("ProductVersion", "8.0.0-dev");
            AddAnnotation("Relational:MaxIdentifierLength", 128);
            AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
        }
    }
}
