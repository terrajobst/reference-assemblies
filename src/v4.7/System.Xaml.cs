// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Xaml.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Xaml.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Xaml.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComCompatibleVersionAttribute(1, 0, 3300, 0)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.SecurityCriticalAttribute((System.Security.SecurityCriticalScope)(0))]
[assembly:System.Windows.Markup.XmlnsDefinitionAttribute("http://schemas.microsoft.com/winfx/2006/xaml", "System.Windows.Markup")]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Windows.Markup.ValueSerializerAttribute))]
namespace System
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoDocumentationNoteAttribute : System.MonoTODOAttribute
    {
        public MonoDocumentationNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoExtensionAttribute : System.MonoTODOAttribute
    {
        public MonoExtensionAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoInternalNoteAttribute : System.MonoTODOAttribute
    {
        public MonoInternalNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoLimitationAttribute : System.MonoTODOAttribute
    {
        public MonoLimitationAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoNotSupportedAttribute : System.MonoTODOAttribute
    {
        public MonoNotSupportedAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoTODOAttribute : System.Attribute
    {
        public MonoTODOAttribute() { }
        public MonoTODOAttribute(string comment) { }
        public string Comment { get { throw null; } }
    }
}
namespace System.Windows.Markup
{
    public partial class AcceptedMarkupExtensionExpressionTypeAttribute : System.Attribute
    {
        public AcceptedMarkupExtensionExpressionTypeAttribute(System.Type type) { }
        public System.Type Type { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(196), Inherited=true)]
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public sealed partial class AmbientAttribute : System.Attribute
    {
        public AmbientAttribute() { }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("PresentationFramework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    [System.Windows.Markup.ContentPropertyAttribute("Items")]
    [System.Windows.Markup.MarkupExtensionReturnTypeAttribute(typeof(System.Array))]
    public partial class ArrayExtension : System.Windows.Markup.MarkupExtension
    {
        public ArrayExtension() { }
        public ArrayExtension(System.Array elements) { }
        public ArrayExtension(System.Type arrayType) { }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        public System.Collections.IList Items { get { throw null; } }
        [System.Windows.Markup.ConstructorArgumentAttribute("arrayType")]
        public System.Type Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public void AddChild(object value) { }
        public void AddText(string text) { }
        public override object ProvideValue(System.IServiceProvider serviceProvider) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(128), AllowMultiple=false, Inherited=false)]
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public sealed partial class ConstructorArgumentAttribute : System.Attribute
    {
        public ConstructorArgumentAttribute(string argumentName) { }
        public string ArgumentName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public sealed partial class ContentPropertyAttribute : System.Attribute
    {
        public ContentPropertyAttribute() { }
        public ContentPropertyAttribute(string name) { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=true, Inherited=true)]
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public sealed partial class ContentWrapperAttribute : System.Attribute
    {
        public ContentWrapperAttribute(System.Type contentWrapper) { }
        public System.Type ContentWrapper { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override object TypeId { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public partial class DateTimeValueSerializer : System.Windows.Markup.ValueSerializer
    {
        public DateTimeValueSerializer() { }
        public override bool CanConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { throw null; }
        public override bool CanConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { throw null; }
        public override object ConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { throw null; }
        public override string ConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(192), AllowMultiple=true)]
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public sealed partial class DependsOnAttribute : System.Attribute
    {
        public DependsOnAttribute(string name) { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override object TypeId { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public sealed partial class DictionaryKeyPropertyAttribute : System.Attribute
    {
        public DictionaryKeyPropertyAttribute(string name) { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public partial interface IComponentConnector
    {
        void Connect(int connectionId, object target);
        void InitializeComponent();
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public partial interface INameScope
    {
        object FindName(string name);
        void RegisterName(string name, object scopedElement);
        void UnregisterName(string name);
    }
    public partial interface INameScopeDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IDictionary<string, object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable, System.Windows.Markup.INameScope
    {
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("PresentationFramework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public partial interface IProvideValueTarget
    {
        object TargetObject { get; }
        object TargetProperty { get; }
    }
    public partial interface IQueryAmbient
    {
        bool IsAmbientPropertyAvailable(string propertyName);
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("PresentationCore, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public partial interface IUriContext
    {
        System.Uri BaseUri { get; set; }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public partial interface IValueSerializerContext : System.ComponentModel.ITypeDescriptorContext, System.IServiceProvider
    {
        System.Windows.Markup.ValueSerializer GetValueSerializerFor(System.ComponentModel.PropertyDescriptor descriptor);
        System.Windows.Markup.ValueSerializer GetValueSerializerFor(System.Type type);
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public partial interface IXamlTypeResolver
    {
        System.Type Resolve(string qualifiedTypeName);
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public abstract partial class MarkupExtension
    {
        protected MarkupExtension() { }
        public abstract object ProvideValue(System.IServiceProvider serviceProvider);
    }
    public sealed partial class MarkupExtensionBracketCharactersAttribute : System.Attribute
    {
        public MarkupExtensionBracketCharactersAttribute(char openingBracket, char closingBracket) { }
        public char ClosingBracket { get { throw null; } }
        public char OpeningBracket { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
    public sealed partial class MarkupExtensionReturnTypeAttribute : System.Attribute
    {
        public MarkupExtensionReturnTypeAttribute() { }
        public MarkupExtensionReturnTypeAttribute(System.Type returnType) { }
        [System.ObsoleteAttribute("Unused. Use MarkupExtensionReturnTypeAttribute(Type) or XamlSetMarkupExtensionAttribute.")]
        public MarkupExtensionReturnTypeAttribute(System.Type returnType, System.Type expressionType) { }
        [System.ObsoleteAttribute("Unused. Use XamlSetMarkupExtensionAttribute functionality instead.")]
        public System.Type ExpressionType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Type ReturnType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public abstract partial class MemberDefinition
    {
        protected MemberDefinition() { }
        public abstract string Name { get; set; }
    }
    public partial class NameReferenceConverter : System.ComponentModel.TypeConverter
    {
        public NameReferenceConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public sealed partial class NameScopePropertyAttribute : System.Attribute
    {
        public NameScopePropertyAttribute(string name) { }
        public NameScopePropertyAttribute(string name, System.Type type) { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Type Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("PresentationFramework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    [System.Windows.Markup.MarkupExtensionReturnTypeAttribute(typeof(object))]
    public partial class NullExtension : System.Windows.Markup.MarkupExtension
    {
        public NullExtension() { }
        public override object ProvideValue(System.IServiceProvider serviceProvider) { throw null; }
    }
    public partial class PropertyDefinition : System.Windows.Markup.MemberDefinition
    {
        public PropertyDefinition() { }
        public System.Collections.Generic.IList<System.Attribute> Attributes { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("public")]
        public string Modifier { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string Name { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute(typeof(System.Xaml.Schema.XamlTypeTypeConverter))]
        public System.Xaml.XamlType Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [System.Windows.Markup.ContentPropertyAttribute("Name")]
    public partial class Reference : System.Windows.Markup.MarkupExtension
    {
        public Reference() { }
        public Reference(string name) { }
        [System.Windows.Markup.ConstructorArgumentAttribute("name")]
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override object ProvideValue(System.IServiceProvider serviceProvider) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1))]
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public sealed partial class RootNamespaceAttribute : System.Attribute
    {
        public RootNamespaceAttribute(string nameSpace) { }
        public string Namespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public sealed partial class RuntimeNamePropertyAttribute : System.Attribute
    {
        public RuntimeNamePropertyAttribute(string name) { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.ComponentModel.TypeConverterAttribute("System.Windows.Markup.StaticExtensionConverter")]
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("PresentationFramework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    [System.Windows.Markup.MarkupExtensionReturnTypeAttribute(typeof(object))]
    public partial class StaticExtension : System.Windows.Markup.MarkupExtension
    {
        public StaticExtension() { }
        public StaticExtension(string member) { }
        [System.Windows.Markup.ConstructorArgumentAttribute("member")]
        public string Member { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        public System.Type MemberType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override object ProvideValue(System.IServiceProvider serviceProvider) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public sealed partial class TrimSurroundingWhitespaceAttribute : System.Attribute
    {
        public TrimSurroundingWhitespaceAttribute() { }
    }
    [System.ComponentModel.TypeConverterAttribute("System.Windows.Markup.TypeExtensionConverter")]
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("PresentationFramework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    [System.Windows.Markup.MarkupExtensionReturnTypeAttribute(typeof(System.Type))]
    public partial class TypeExtension : System.Windows.Markup.MarkupExtension
    {
        public TypeExtension() { }
        public TypeExtension(string typeName) { }
        public TypeExtension(System.Type type) { }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.Windows.Markup.ConstructorArgumentAttribute("type")]
        public System.Type Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public string TypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override object ProvideValue(System.IServiceProvider serviceProvider) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public sealed partial class UidPropertyAttribute : System.Attribute
    {
        public UidPropertyAttribute(string name) { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
    public sealed partial class UsableDuringInitializationAttribute : System.Attribute
    {
        public UsableDuringInitializationAttribute(bool usable) { }
        public bool Usable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public abstract partial class ValueSerializer
    {
        protected ValueSerializer() { }
        public virtual bool CanConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { throw null; }
        public virtual bool CanConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { throw null; }
        public virtual object ConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { throw null; }
        public virtual string ConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { throw null; }
        protected System.Exception GetConvertFromException(object value) { throw null; }
        protected System.Exception GetConvertToException(object value, System.Type destinationType) { throw null; }
        public static System.Windows.Markup.ValueSerializer GetSerializerFor(System.ComponentModel.PropertyDescriptor descriptor) { throw null; }
        public static System.Windows.Markup.ValueSerializer GetSerializerFor(System.ComponentModel.PropertyDescriptor descriptor, System.Windows.Markup.IValueSerializerContext context) { throw null; }
        public static System.Windows.Markup.ValueSerializer GetSerializerFor(System.Type type) { throw null; }
        public static System.Windows.Markup.ValueSerializer GetSerializerFor(System.Type type, System.Windows.Markup.IValueSerializerContext context) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<System.Type> TypeReferences(object value, System.Windows.Markup.IValueSerializerContext context) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public sealed partial class WhitespaceSignificantCollectionAttribute : System.Attribute
    {
        public WhitespaceSignificantCollectionAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(132), AllowMultiple=false, Inherited=true)]
    public sealed partial class XamlDeferLoadAttribute : System.Attribute
    {
        public XamlDeferLoadAttribute(string loaderType, string contentType) { }
        public XamlDeferLoadAttribute(System.Type loaderType, System.Type contentType) { }
        public System.Type ContentType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string ContentTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Type LoaderType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string LoaderTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=true, AllowMultiple=false)]
    public sealed partial class XamlSetMarkupExtensionAttribute : System.Attribute
    {
        public XamlSetMarkupExtensionAttribute(string xamlSetMarkupExtensionHandler) { }
        public string XamlSetMarkupExtensionHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class XamlSetMarkupExtensionEventArgs : System.Windows.Markup.XamlSetValueEventArgs
    {
        public XamlSetMarkupExtensionEventArgs(System.Xaml.XamlMember member, System.Windows.Markup.MarkupExtension value, System.IServiceProvider serviceProvider) : base (default(System.Xaml.XamlMember), default(object)) { }
        public System.Windows.Markup.MarkupExtension MarkupExtension { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.IServiceProvider ServiceProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override void CallBase() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=true, AllowMultiple=false)]
    public sealed partial class XamlSetTypeConverterAttribute : System.Attribute
    {
        public XamlSetTypeConverterAttribute(string xamlSetTypeConverterHandler) { }
        public string XamlSetTypeConverterHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class XamlSetTypeConverterEventArgs : System.Windows.Markup.XamlSetValueEventArgs
    {
        public XamlSetTypeConverterEventArgs(System.Xaml.XamlMember member, System.ComponentModel.TypeConverter typeConverter, object value, System.ComponentModel.ITypeDescriptorContext serviceProvider, System.Globalization.CultureInfo cultureInfo) : base (default(System.Xaml.XamlMember), default(object)) { }
        public System.Globalization.CultureInfo CultureInfo { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.ComponentModel.ITypeDescriptorContext ServiceProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.ComponentModel.TypeConverter TypeConverter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override void CallBase() { }
    }
    public partial class XamlSetValueEventArgs : System.EventArgs
    {
        public XamlSetValueEventArgs(System.Xaml.XamlMember member, object value) { }
        public bool Handled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Xaml.XamlMember Member { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual void CallBase() { }
    }
    [System.Windows.Markup.ContentPropertyAttribute("Text")]
    public sealed partial class XData
    {
        public XData() { }
        public string Text { get { throw null; } set { } }
        public object XmlReader { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public sealed partial class XmlLangPropertyAttribute : System.Attribute
    {
        public XmlLangPropertyAttribute(string name) { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=true)]
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public sealed partial class XmlnsCompatibleWithAttribute : System.Attribute
    {
        public XmlnsCompatibleWithAttribute(string oldNamespace, string newNamespace) { }
        public string NewNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string OldNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=true)]
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public sealed partial class XmlnsDefinitionAttribute : System.Attribute
    {
        public XmlnsDefinitionAttribute(string xmlNamespace, string clrNamespace) { }
        public string AssemblyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ClrNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string XmlNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=true)]
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public sealed partial class XmlnsPrefixAttribute : System.Attribute
    {
        public XmlnsPrefixAttribute(string xmlNamespace, string prefix) { }
        public string Prefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string XmlNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
}
namespace System.Xaml
{
    public partial class AmbientPropertyValue
    {
        public AmbientPropertyValue(System.Xaml.XamlMember property, object value) { }
        public System.Xaml.XamlMember RetrievedProperty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class AttachableMemberIdentifier : System.IEquatable<System.Xaml.AttachableMemberIdentifier>
    {
        public AttachableMemberIdentifier(System.Type declaringType, string memberName) { }
        public System.Type DeclaringType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string MemberName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Xaml.AttachableMemberIdentifier other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Xaml.AttachableMemberIdentifier left, System.Xaml.AttachableMemberIdentifier right) { throw null; }
        public static bool operator !=(System.Xaml.AttachableMemberIdentifier left, System.Xaml.AttachableMemberIdentifier right) { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class AttachablePropertyServices
    {
        public static void CopyPropertiesTo(object instance, System.Collections.Generic.KeyValuePair<System.Xaml.AttachableMemberIdentifier, object>[] array, int index) { }
        public static int GetAttachedPropertyCount(object instance) { throw null; }
        public static bool RemoveProperty(object instance, System.Xaml.AttachableMemberIdentifier name) { throw null; }
        public static void SetProperty(object instance, System.Xaml.AttachableMemberIdentifier name, object value) { }
        public static bool TryGetProperty(object instance, System.Xaml.AttachableMemberIdentifier name, out object value) { value = default(object); throw null; }
        public static bool TryGetProperty<T>(object instance, System.Xaml.AttachableMemberIdentifier name, out T value) { value = default(T); throw null; }
    }
    public partial interface IAmbientProvider
    {
        System.Collections.Generic.IEnumerable<System.Xaml.AmbientPropertyValue> GetAllAmbientValues(System.Collections.Generic.IEnumerable<System.Xaml.XamlType> ceilingTypes, bool searchLiveStackOnly, System.Collections.Generic.IEnumerable<System.Xaml.XamlType> types, params System.Xaml.XamlMember[] properties);
        System.Collections.Generic.IEnumerable<System.Xaml.AmbientPropertyValue> GetAllAmbientValues(System.Collections.Generic.IEnumerable<System.Xaml.XamlType> ceilingTypes, params System.Xaml.XamlMember[] properties);
        System.Collections.Generic.IEnumerable<object> GetAllAmbientValues(params System.Xaml.XamlType[] types);
        System.Xaml.AmbientPropertyValue GetFirstAmbientValue(System.Collections.Generic.IEnumerable<System.Xaml.XamlType> ceilingTypes, params System.Xaml.XamlMember[] properties);
        object GetFirstAmbientValue(params System.Xaml.XamlType[] types);
    }
    public partial interface IAttachedPropertyStore
    {
        int PropertyCount { get; }
        void CopyPropertiesTo(System.Collections.Generic.KeyValuePair<System.Xaml.AttachableMemberIdentifier, object>[] array, int index);
        bool RemoveProperty(System.Xaml.AttachableMemberIdentifier attachableMemberIdentifier);
        void SetProperty(System.Xaml.AttachableMemberIdentifier attachableMemberIdentifier, object value);
        bool TryGetProperty(System.Xaml.AttachableMemberIdentifier attachableMemberIdentifier, out object value);
    }
    public partial interface IDestinationTypeProvider
    {
        System.Type GetDestinationType();
    }
    public partial interface INamespacePrefixLookup
    {
        string LookupPrefix(string ns);
    }
    public partial interface IRootObjectProvider
    {
        object RootObject { get; }
    }
    public partial interface IXamlIndexingReader
    {
        int Count { get; }
        int CurrentIndex { get; set; }
    }
    public partial interface IXamlLineInfo
    {
        bool HasLineInfo { get; }
        int LineNumber { get; }
        int LinePosition { get; }
    }
    public partial interface IXamlLineInfoConsumer
    {
        bool ShouldProvideLineInfo { get; }
        void SetLineInfo(int lineNumber, int linePosition);
    }
    public partial interface IXamlNameProvider
    {
        string GetName(object value);
    }
    public partial interface IXamlNameResolver
    {
        bool IsFixupTokenAvailable { get; }
        event System.EventHandler OnNameScopeInitializationComplete;
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>> GetAllNamesAndValuesInScope();
        object GetFixupToken(System.Collections.Generic.IEnumerable<string> names);
        object GetFixupToken(System.Collections.Generic.IEnumerable<string> names, bool canAssignDirectly);
        object Resolve(string name);
        object Resolve(string name, out bool isFullyInitialized);
    }
    public partial interface IXamlNamespaceResolver
    {
        string GetNamespace(string prefix);
        System.Collections.Generic.IEnumerable<System.Xaml.NamespaceDeclaration> GetNamespacePrefixes();
    }
    public partial interface IXamlObjectWriterFactory
    {
        System.Xaml.XamlObjectWriterSettings GetParentSettings();
        System.Xaml.XamlObjectWriter GetXamlObjectWriter(System.Xaml.XamlObjectWriterSettings settings);
    }
    public partial interface IXamlSchemaContextProvider
    {
        System.Xaml.XamlSchemaContext SchemaContext { get; }
    }
    public partial class NamespaceDeclaration
    {
        public NamespaceDeclaration(string ns, string prefix) { }
        public string Namespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Prefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class XamlBackgroundReader : System.Xaml.XamlReader, System.Xaml.IXamlLineInfo
    {
        public XamlBackgroundReader(System.Xaml.XamlReader wrappedReader) { }
        public bool HasLineInfo { get { throw null; } }
        public override bool IsEof { get { throw null; } }
        public int LineNumber { get { throw null; } }
        [System.MonoTODOAttribute("always returns 0")]
        public int LinePosition { get { throw null; } }
        public override System.Xaml.XamlMember Member { get { throw null; } }
        public override System.Xaml.NamespaceDeclaration Namespace { get { throw null; } }
        public override System.Xaml.XamlNodeType NodeType { get { throw null; } }
        public override System.Xaml.XamlSchemaContext SchemaContext { get { throw null; } }
        public override System.Xaml.XamlType Type { get { throw null; } }
        public override object Value { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        public override bool Read() { throw null; }
        public void StartThread() { }
        public void StartThread(string threadName) { }
    }
    public abstract partial class XamlDeferringLoader
    {
        protected XamlDeferringLoader() { }
        public abstract object Load(System.Xaml.XamlReader xamlReader, System.IServiceProvider serviceProvider);
        public abstract System.Xaml.XamlReader Save(object value, System.IServiceProvider serviceProvider);
    }
    public partial class XamlDirective : System.Xaml.XamlMember
    {
        public XamlDirective(System.Collections.Generic.IEnumerable<string> xamlNamespaces, string name, System.Xaml.XamlType xamlType, System.Xaml.Schema.XamlValueConverter<System.ComponentModel.TypeConverter> typeConverter, System.Xaml.Schema.AllowedMemberLocations allowedLocation) : base (default(string), default(System.Xaml.XamlType), default(bool)) { }
        public XamlDirective(string xamlNamespace, string name) : base (default(string), default(System.Xaml.XamlType), default(bool)) { }
        public System.Xaml.Schema.AllowedMemberLocations AllowedLocation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override int GetHashCode() { throw null; }
        public override System.Collections.Generic.IList<string> GetXamlNamespaces() { throw null; }
        protected sealed override System.Reflection.ICustomAttributeProvider LookupCustomAttributeProvider() { throw null; }
        protected sealed override System.Xaml.Schema.XamlValueConverter<System.Xaml.XamlDeferringLoader> LookupDeferringLoader() { throw null; }
        protected sealed override System.Collections.Generic.IList<System.Xaml.XamlMember> LookupDependsOn() { throw null; }
        protected sealed override System.Xaml.Schema.XamlMemberInvoker LookupInvoker() { throw null; }
        protected sealed override bool LookupIsAmbient() { throw null; }
        protected sealed override bool LookupIsEvent() { throw null; }
        protected sealed override bool LookupIsReadOnly() { throw null; }
        protected sealed override bool LookupIsReadPublic() { throw null; }
        protected sealed override bool LookupIsUnknown() { throw null; }
        protected sealed override bool LookupIsWriteOnly() { throw null; }
        protected sealed override bool LookupIsWritePublic() { throw null; }
        protected sealed override System.Xaml.XamlType LookupTargetType() { throw null; }
        protected sealed override System.Xaml.XamlType LookupType() { throw null; }
        protected sealed override System.Xaml.Schema.XamlValueConverter<System.ComponentModel.TypeConverter> LookupTypeConverter() { throw null; }
        protected sealed override System.Reflection.MethodInfo LookupUnderlyingGetter() { throw null; }
        protected sealed override System.Reflection.MemberInfo LookupUnderlyingMember() { throw null; }
        protected sealed override System.Reflection.MethodInfo LookupUnderlyingSetter() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.SerializableAttribute]
    public partial class XamlDuplicateMemberException : System.Xaml.XamlException
    {
        public XamlDuplicateMemberException() { }
        protected XamlDuplicateMemberException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XamlDuplicateMemberException(string message) { }
        public XamlDuplicateMemberException(string message, System.Exception innerException) { }
        public XamlDuplicateMemberException(System.Xaml.XamlMember member, System.Xaml.XamlType type) { }
        public System.Xaml.XamlMember DuplicateMember { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Xaml.XamlType ParentType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.SerializableAttribute]
    public partial class XamlException : System.Exception
    {
        public XamlException() { }
        protected XamlException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XamlException(string message) { }
        public XamlException(string message, System.Exception innerException) { }
        public XamlException(string message, System.Exception innerException, int lineNumber, int linePosition) { }
        public int LineNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public int LinePosition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public override string Message { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.SerializableAttribute]
    public partial class XamlInternalException : System.Xaml.XamlException
    {
        public XamlInternalException() { }
        protected XamlInternalException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XamlInternalException(string message) { }
        public XamlInternalException(string message, System.Exception innerException) { }
    }
    public static partial class XamlLanguage
    {
        public const string Xaml2006Namespace = "http://schemas.microsoft.com/winfx/2006/xaml";
        public const string Xml1998Namespace = "http://www.w3.org/XML/1998/namespace";
        public static System.Collections.ObjectModel.ReadOnlyCollection<System.Xaml.XamlDirective> AllDirectives { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Collections.ObjectModel.ReadOnlyCollection<System.Xaml.XamlType> AllTypes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective Arguments { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType Array { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective AsyncRecords { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective Base { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType Boolean { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType Byte { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType Char { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective Class { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective ClassAttributes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective ClassModifier { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective Code { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective ConnectionId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType Decimal { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType Double { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective FactoryMethod { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective FieldModifier { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective Initialization { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType Int16 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType Int32 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType Int64 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective Items { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective Key { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective Lang { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType Member { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective Members { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType Null { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType Object { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective PositionalParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType Property { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType Reference { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective Shared { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType Single { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective Space { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType Static { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType String { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective Subclass { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective SynchronousMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType TimeSpan { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective TypeArguments { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective Uid { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlDirective UnknownContent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.XamlType Uri { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Collections.Generic.IList<string> XamlNamespaces { get { throw null; } }
        public static System.Xaml.XamlType XData { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Collections.Generic.IList<string> XmlNamespaces { get { throw null; } }
    }
    public partial class XamlMember : System.IEquatable<System.Xaml.XamlMember>
    {
        public XamlMember(System.Reflection.EventInfo eventInfo, System.Xaml.XamlSchemaContext schemaContext) { }
        public XamlMember(System.Reflection.EventInfo eventInfo, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.Schema.XamlMemberInvoker invoker) { }
        public XamlMember(System.Reflection.PropertyInfo propertyInfo, System.Xaml.XamlSchemaContext schemaContext) { }
        public XamlMember(System.Reflection.PropertyInfo propertyInfo, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.Schema.XamlMemberInvoker invoker) { }
        public XamlMember(string attachablePropertyName, System.Reflection.MethodInfo getter, System.Reflection.MethodInfo setter, System.Xaml.XamlSchemaContext schemaContext) { }
        public XamlMember(string attachablePropertyName, System.Reflection.MethodInfo getter, System.Reflection.MethodInfo setter, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.Schema.XamlMemberInvoker invoker) { }
        public XamlMember(string attachableEventName, System.Reflection.MethodInfo adder, System.Xaml.XamlSchemaContext schemaContext) { }
        public XamlMember(string attachableEventName, System.Reflection.MethodInfo adder, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.Schema.XamlMemberInvoker invoker) { }
        public XamlMember(string name, System.Xaml.XamlType declaringType, bool isAttachable) { }
        public System.Xaml.XamlType DeclaringType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Xaml.Schema.XamlValueConverter<System.Xaml.XamlDeferringLoader> DeferringLoader { get { throw null; } }
        public System.Collections.Generic.IList<System.Xaml.XamlMember> DependsOn { get { throw null; } }
        public System.Xaml.Schema.XamlMemberInvoker Invoker { get { throw null; } }
        public bool IsAmbient { get { throw null; } }
        public bool IsAttachable { get { throw null; } }
        public bool IsDirective { get { throw null; } }
        public bool IsEvent { get { throw null; } }
        public bool IsNameValid { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsReadPublic { get { throw null; } }
        public bool IsUnknown { get { throw null; } }
        public bool IsWriteOnly { get { throw null; } }
        public bool IsWritePublic { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<char, char> MarkupExtensionBracketCharacters { get { throw null; } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string PreferredXamlNamespace { get { throw null; } }
        public System.ComponentModel.DesignerSerializationVisibility SerializationVisibility { get { throw null; } }
        public System.Xaml.XamlType TargetType { get { throw null; } }
        public System.Xaml.XamlType Type { get { throw null; } }
        public System.Xaml.Schema.XamlValueConverter<System.ComponentModel.TypeConverter> TypeConverter { get { throw null; } }
        public System.Reflection.MemberInfo UnderlyingMember { get { throw null; } }
        public System.Xaml.Schema.XamlValueConverter<System.Windows.Markup.ValueSerializer> ValueSerializer { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Xaml.XamlMember other) { throw null; }
        public override int GetHashCode() { throw null; }
        public virtual System.Collections.Generic.IList<string> GetXamlNamespaces() { throw null; }
        protected virtual System.Reflection.ICustomAttributeProvider LookupCustomAttributeProvider() { throw null; }
        protected virtual System.Xaml.Schema.XamlValueConverter<System.Xaml.XamlDeferringLoader> LookupDeferringLoader() { throw null; }
        protected virtual System.Collections.Generic.IList<System.Xaml.XamlMember> LookupDependsOn() { throw null; }
        protected virtual System.Xaml.Schema.XamlMemberInvoker LookupInvoker() { throw null; }
        protected virtual bool LookupIsAmbient() { throw null; }
        protected virtual bool LookupIsEvent() { throw null; }
        protected virtual bool LookupIsReadOnly() { throw null; }
        protected virtual bool LookupIsReadPublic() { throw null; }
        protected virtual bool LookupIsUnknown() { throw null; }
        protected virtual bool LookupIsWriteOnly() { throw null; }
        protected virtual bool LookupIsWritePublic() { throw null; }
        protected virtual System.Collections.Generic.IReadOnlyDictionary<char, char> LookupMarkupExtensionBracketCharacters() { throw null; }
        protected virtual System.Xaml.XamlType LookupTargetType() { throw null; }
        protected virtual System.Xaml.XamlType LookupType() { throw null; }
        protected virtual System.Xaml.Schema.XamlValueConverter<System.ComponentModel.TypeConverter> LookupTypeConverter() { throw null; }
        protected virtual System.Reflection.MethodInfo LookupUnderlyingGetter() { throw null; }
        protected virtual System.Reflection.MemberInfo LookupUnderlyingMember() { throw null; }
        protected virtual System.Reflection.MethodInfo LookupUnderlyingSetter() { throw null; }
        protected virtual System.Xaml.Schema.XamlValueConverter<System.Windows.Markup.ValueSerializer> LookupValueSerializer() { throw null; }
        public static bool operator ==(System.Xaml.XamlMember xamlMember1, System.Xaml.XamlMember xamlMember2) { throw null; }
        public static bool operator !=(System.Xaml.XamlMember xamlMember1, System.Xaml.XamlMember xamlMember2) { throw null; }
        [System.MonoTODOAttribute("there are some patterns that return different kind of value: e.g. List<int>.Capacity")]
        public override string ToString() { throw null; }
    }
    public partial class XamlNodeList
    {
        public XamlNodeList(System.Xaml.XamlSchemaContext schemaContext) { }
        public XamlNodeList(System.Xaml.XamlSchemaContext schemaContext, int size) { }
        public int Count { get { throw null; } }
        public System.Xaml.XamlWriter Writer { get { throw null; } }
        public void Clear() { }
        public System.Xaml.XamlReader GetReader() { throw null; }
    }
    public partial class XamlNodeQueue
    {
        public XamlNodeQueue(System.Xaml.XamlSchemaContext schemaContext) { }
        public int Count { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        public System.Xaml.XamlReader Reader { get { throw null; } }
        public System.Xaml.XamlWriter Writer { get { throw null; } }
    }
    public enum XamlNodeType : byte
    {
        EndMember = (byte)5,
        EndObject = (byte)3,
        GetObject = (byte)2,
        NamespaceDeclaration = (byte)7,
        None = (byte)0,
        StartMember = (byte)4,
        StartObject = (byte)1,
        Value = (byte)6,
    }
    public partial class XamlObjectEventArgs : System.EventArgs
    {
        public XamlObjectEventArgs(object instance) { }
        public int ElementLineNumber { get { throw null; } }
        public int ElementLinePosition { get { throw null; } }
        public object Instance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Uri SourceBamlUri { get { throw null; } }
    }
    public partial class XamlObjectReader : System.Xaml.XamlReader
    {
        public XamlObjectReader(object instance) { }
        public XamlObjectReader(object instance, System.Xaml.XamlObjectReaderSettings settings) { }
        public XamlObjectReader(object instance, System.Xaml.XamlSchemaContext schemaContext) { }
        public XamlObjectReader(object instance, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.XamlObjectReaderSettings settings) { }
        public virtual object Instance { get { throw null; } }
        public override bool IsEof { get { throw null; } }
        public override System.Xaml.XamlMember Member { get { throw null; } }
        public override System.Xaml.NamespaceDeclaration Namespace { get { throw null; } }
        public override System.Xaml.XamlNodeType NodeType { get { throw null; } }
        public override System.Xaml.XamlSchemaContext SchemaContext { get { throw null; } }
        public override System.Xaml.XamlType Type { get { throw null; } }
        public override object Value { get { throw null; } }
        public override bool Read() { throw null; }
    }
    [System.SerializableAttribute]
    public partial class XamlObjectReaderException : System.Xaml.XamlException
    {
        public XamlObjectReaderException() { }
        protected XamlObjectReaderException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XamlObjectReaderException(string message) { }
        public XamlObjectReaderException(string message, System.Exception innerException) { }
    }
    public partial class XamlObjectReaderSettings : System.Xaml.XamlReaderSettings
    {
        public XamlObjectReaderSettings() { }
        public bool RequireExplicitContentVisibility { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class XamlObjectWriter : System.Xaml.XamlWriter, System.Xaml.IXamlLineInfoConsumer
    {
        public XamlObjectWriter(System.Xaml.XamlSchemaContext schemaContext) { }
        public XamlObjectWriter(System.Xaml.XamlSchemaContext schemaContext, System.Xaml.XamlObjectWriterSettings settings) { }
        public virtual object Result { get { throw null; } }
        public System.Windows.Markup.INameScope RootNameScope { get { throw null; } }
        public override System.Xaml.XamlSchemaContext SchemaContext { get { throw null; } }
        public bool ShouldProvideLineInfo { get { throw null; } }
        public void Clear() { }
        protected override void Dispose(bool disposing) { }
        protected virtual void OnAfterBeginInit(object value) { }
        protected virtual void OnAfterEndInit(object value) { }
        protected virtual void OnAfterProperties(object value) { }
        protected virtual void OnBeforeProperties(object value) { }
        protected virtual bool OnSetValue(object eventSender, System.Xaml.XamlMember member, object value) { throw null; }
        public void SetLineInfo(int lineNumber, int linePosition) { }
        public override void WriteEndMember() { }
        public override void WriteEndObject() { }
        public override void WriteGetObject() { }
        public override void WriteNamespace(System.Xaml.NamespaceDeclaration namespaceDeclaration) { }
        public override void WriteStartMember(System.Xaml.XamlMember property) { }
        public override void WriteStartObject(System.Xaml.XamlType xamlType) { }
        public override void WriteValue(object value) { }
    }
    [System.SerializableAttribute]
    public partial class XamlObjectWriterException : System.Xaml.XamlException
    {
        public XamlObjectWriterException() { }
        protected XamlObjectWriterException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XamlObjectWriterException(string message) { }
        public XamlObjectWriterException(string message, System.Exception innerException) { }
    }
    public partial class XamlObjectWriterSettings : System.Xaml.XamlWriterSettings
    {
        public XamlObjectWriterSettings() { }
        public XamlObjectWriterSettings(System.Xaml.XamlObjectWriterSettings settings) { }
        [System.MonoTODOAttribute("Ignored")]
        public System.Xaml.Permissions.XamlAccessLevel AccessLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.EventHandler<System.Xaml.XamlObjectEventArgs> AfterBeginInitHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.EventHandler<System.Xaml.XamlObjectEventArgs> AfterEndInitHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.EventHandler<System.Xaml.XamlObjectEventArgs> AfterPropertiesHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.EventHandler<System.Xaml.XamlObjectEventArgs> BeforePropertiesHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Markup.INameScope ExternalNameScope { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute("Ignored")]
        public bool IgnoreCanConvert { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute("Ignored")]
        public bool PreferUnconvertedDictionaryKeys { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool RegisterNamesOnExternalNamescope { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public object RootObjectInstance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute("Ignored")]
        public bool SkipDuplicatePropertyCheck { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute("Ignored")]
        public bool SkipProvideValueOnRoot { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Uri SourceBamlUri { get { throw null; } set { } }
        public System.EventHandler<System.Windows.Markup.XamlSetValueEventArgs> XamlSetValueHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [System.SerializableAttribute]
    public partial class XamlParseException : System.Xaml.XamlException
    {
        public XamlParseException() { }
        protected XamlParseException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XamlParseException(string message) { }
        public XamlParseException(string message, System.Exception innerException) { }
    }
    public abstract partial class XamlReader : System.IDisposable
    {
        protected XamlReader() { }
        protected bool IsDisposed { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public abstract bool IsEof { get; }
        public abstract System.Xaml.XamlMember Member { get; }
        public abstract System.Xaml.NamespaceDeclaration Namespace { get; }
        public abstract System.Xaml.XamlNodeType NodeType { get; }
        public abstract System.Xaml.XamlSchemaContext SchemaContext { get; }
        public abstract System.Xaml.XamlType Type { get; }
        public abstract object Value { get; }
        public void Close() { }
        protected virtual void Dispose(bool disposing) { }
        public abstract bool Read();
        public virtual System.Xaml.XamlReader ReadSubtree() { throw null; }
        public virtual void Skip() { }
        void System.IDisposable.Dispose() { }
    }
    public partial class XamlReaderSettings
    {
        public XamlReaderSettings() { }
        public XamlReaderSettings(System.Xaml.XamlReaderSettings settings) { }
        public bool AllowProtectedMembersOnRoot { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Uri BaseUri { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IgnoreUidsOnPropertyElements { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Reflection.Assembly LocalAssembly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool ProvideLineInfo { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool ValuesMustBeString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class XamlSchemaContext
    {
        public XamlSchemaContext() { }
        public XamlSchemaContext(System.Collections.Generic.IEnumerable<System.Reflection.Assembly> referenceAssemblies) { }
        public XamlSchemaContext(System.Collections.Generic.IEnumerable<System.Reflection.Assembly> referenceAssemblies, System.Xaml.XamlSchemaContextSettings settings) { }
        public XamlSchemaContext(System.Xaml.XamlSchemaContextSettings settings) { }
        public bool FullyQualifyAssemblyNamesInClrNamespaces { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IList<System.Reflection.Assembly> ReferenceAssemblies { get { throw null; } }
        public bool SupportMarkupExtensionsWithDuplicateArity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        ~XamlSchemaContext() { }
        public virtual System.Collections.Generic.IEnumerable<string> GetAllXamlNamespaces() { throw null; }
        public virtual System.Collections.Generic.ICollection<System.Xaml.XamlType> GetAllXamlTypes(string xamlNamespace) { throw null; }
        public virtual string GetPreferredPrefix(string xmlns) { throw null; }
        protected internal System.Xaml.Schema.XamlValueConverter<TConverterBase> GetValueConverter<TConverterBase>(System.Type converterType, System.Xaml.XamlType targetType) where TConverterBase : class { throw null; }
        public virtual System.Xaml.XamlDirective GetXamlDirective(string xamlNamespace, string name) { throw null; }
        protected internal virtual System.Xaml.XamlType GetXamlType(string xamlNamespace, string name, params System.Xaml.XamlType[] typeArguments) { throw null; }
        public virtual System.Xaml.XamlType GetXamlType(System.Type type) { throw null; }
        public System.Xaml.XamlType GetXamlType(System.Xaml.Schema.XamlTypeName xamlTypeName) { throw null; }
        protected internal virtual System.Reflection.Assembly OnAssemblyResolve(string assemblyName) { throw null; }
        public virtual bool TryGetCompatibleXamlNamespace(string xamlNamespace, out string compatibleNamespace) { compatibleNamespace = default(string); throw null; }
    }
    public partial class XamlSchemaContextSettings
    {
        public XamlSchemaContextSettings() { }
        public XamlSchemaContextSettings(System.Xaml.XamlSchemaContextSettings settings) { }
        public bool FullyQualifyAssemblyNamesInClrNamespaces { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool SupportMarkupExtensionsWithDuplicateArity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [System.SerializableAttribute]
    public partial class XamlSchemaException : System.Xaml.XamlException
    {
        public XamlSchemaException() { }
        protected XamlSchemaException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XamlSchemaException(string message) { }
        public XamlSchemaException(string message, System.Exception innerException) { }
    }
    public static partial class XamlServices
    {
        public static object Load(System.IO.Stream stream) { throw null; }
        public static object Load(System.IO.TextReader textReader) { throw null; }
        public static object Load(string fileName) { throw null; }
        public static object Load(System.Xaml.XamlReader xamlReader) { throw null; }
        public static object Load(System.Xml.XmlReader xmlReader) { throw null; }
        public static object Parse(string xaml) { throw null; }
        public static void Save(System.IO.Stream stream, object instance) { }
        public static void Save(System.IO.TextWriter writer, object instance) { }
        public static string Save(object instance) { throw null; }
        public static void Save(string fileName, object instance) { }
        public static void Save(System.Xaml.XamlWriter writer, object instance) { }
        public static void Save(System.Xml.XmlWriter writer, object instance) { }
        public static void Transform(System.Xaml.XamlReader xamlReader, System.Xaml.XamlWriter xamlWriter) { }
        public static void Transform(System.Xaml.XamlReader xamlReader, System.Xaml.XamlWriter xamlWriter, bool closeWriter) { }
    }
    public partial class XamlType : System.IEquatable<System.Xaml.XamlType>
    {
        protected XamlType(string typeName, System.Collections.Generic.IList<System.Xaml.XamlType> typeArguments, System.Xaml.XamlSchemaContext schemaContext) { }
        public XamlType(string unknownTypeNamespace, string unknownTypeName, System.Collections.Generic.IList<System.Xaml.XamlType> typeArguments, System.Xaml.XamlSchemaContext schemaContext) { }
        public XamlType(System.Type underlyingType, System.Xaml.XamlSchemaContext schemaContext) { }
        public XamlType(System.Type underlyingType, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.Schema.XamlTypeInvoker invoker) { }
        public System.Collections.Generic.IList<System.Xaml.XamlType> AllowedContentTypes { get { throw null; } }
        public System.Xaml.XamlType BaseType { get { throw null; } }
        public bool ConstructionRequiresArguments { get { throw null; } }
        public System.Xaml.XamlMember ContentProperty { get { throw null; } }
        public System.Collections.Generic.IList<System.Xaml.XamlType> ContentWrappers { get { throw null; } }
        public System.Xaml.Schema.XamlValueConverter<System.Xaml.XamlDeferringLoader> DeferringLoader { get { throw null; } }
        public System.Xaml.Schema.XamlTypeInvoker Invoker { get { throw null; } }
        public bool IsAmbient { get { throw null; } }
        public bool IsArray { get { throw null; } }
        public bool IsCollection { get { throw null; } }
        public bool IsConstructible { get { throw null; } }
        public bool IsDictionary { get { throw null; } }
        public bool IsGeneric { get { throw null; } }
        public bool IsMarkupExtension { get { throw null; } }
        public bool IsNameScope { get { throw null; } }
        public bool IsNameValid { get { throw null; } }
        public bool IsNullable { get { throw null; } }
        public bool IsPublic { get { throw null; } }
        public bool IsUnknown { get { throw null; } }
        public bool IsUsableDuringInitialization { get { throw null; } }
        public bool IsWhitespaceSignificantCollection { get { throw null; } }
        public bool IsXData { get { throw null; } }
        public System.Xaml.XamlType ItemType { get { throw null; } }
        public System.Xaml.XamlType KeyType { get { throw null; } }
        public System.Xaml.XamlType MarkupExtensionReturnType { get { throw null; } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string PreferredXamlNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Xaml.XamlSchemaContext SchemaContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool TrimSurroundingWhitespace { get { throw null; } }
        public System.Collections.Generic.IList<System.Xaml.XamlType> TypeArguments { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Xaml.Schema.XamlValueConverter<System.ComponentModel.TypeConverter> TypeConverter { get { throw null; } }
        public System.Type UnderlyingType { get { throw null; } }
        public System.Xaml.Schema.XamlValueConverter<System.Windows.Markup.ValueSerializer> ValueSerializer { get { throw null; } }
        public virtual bool CanAssignTo(System.Xaml.XamlType xamlType) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Xaml.XamlType other) { throw null; }
        public System.Xaml.XamlMember GetAliasedProperty(System.Xaml.XamlDirective directive) { throw null; }
        public System.Collections.Generic.ICollection<System.Xaml.XamlMember> GetAllAttachableMembers() { throw null; }
        public System.Collections.Generic.ICollection<System.Xaml.XamlMember> GetAllMembers() { throw null; }
        public System.Xaml.XamlMember GetAttachableMember(string name) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.Xaml.XamlMember GetMember(string name) { throw null; }
        public System.Collections.Generic.IList<System.Xaml.XamlType> GetPositionalParameters(int parameterCount) { throw null; }
        public virtual System.Collections.Generic.IList<string> GetXamlNamespaces() { throw null; }
        protected virtual System.Xaml.XamlMember LookupAliasedProperty(System.Xaml.XamlDirective directive) { throw null; }
        protected virtual System.Collections.Generic.IEnumerable<System.Xaml.XamlMember> LookupAllAttachableMembers() { throw null; }
        protected virtual System.Collections.Generic.IEnumerable<System.Xaml.XamlMember> LookupAllMembers() { throw null; }
        protected virtual System.Collections.Generic.IList<System.Xaml.XamlType> LookupAllowedContentTypes() { throw null; }
        protected virtual System.Xaml.XamlMember LookupAttachableMember(string name) { throw null; }
        protected virtual System.Xaml.XamlType LookupBaseType() { throw null; }
        protected virtual System.Xaml.Schema.XamlCollectionKind LookupCollectionKind() { throw null; }
        protected virtual bool LookupConstructionRequiresArguments() { throw null; }
        protected virtual System.Xaml.XamlMember LookupContentProperty() { throw null; }
        protected virtual System.Collections.Generic.IList<System.Xaml.XamlType> LookupContentWrappers() { throw null; }
        protected virtual System.Reflection.ICustomAttributeProvider LookupCustomAttributeProvider() { throw null; }
        protected virtual System.Xaml.Schema.XamlValueConverter<System.Xaml.XamlDeferringLoader> LookupDeferringLoader() { throw null; }
        protected virtual System.Xaml.Schema.XamlTypeInvoker LookupInvoker() { throw null; }
        protected virtual bool LookupIsAmbient() { throw null; }
        protected virtual bool LookupIsConstructible() { throw null; }
        protected virtual bool LookupIsMarkupExtension() { throw null; }
        protected virtual bool LookupIsNameScope() { throw null; }
        protected virtual bool LookupIsNullable() { throw null; }
        protected virtual bool LookupIsPublic() { throw null; }
        protected virtual bool LookupIsUnknown() { throw null; }
        protected virtual bool LookupIsWhitespaceSignificantCollection() { throw null; }
        protected virtual bool LookupIsXData() { throw null; }
        protected virtual System.Xaml.XamlType LookupItemType() { throw null; }
        protected virtual System.Xaml.XamlType LookupKeyType() { throw null; }
        protected virtual System.Xaml.XamlType LookupMarkupExtensionReturnType() { throw null; }
        protected virtual System.Xaml.XamlMember LookupMember(string name, bool skipReadOnlyCheck) { throw null; }
        protected virtual System.Collections.Generic.IList<System.Xaml.XamlType> LookupPositionalParameters(int parameterCount) { throw null; }
        protected virtual System.EventHandler<System.Windows.Markup.XamlSetMarkupExtensionEventArgs> LookupSetMarkupExtensionHandler() { throw null; }
        protected virtual System.EventHandler<System.Windows.Markup.XamlSetTypeConverterEventArgs> LookupSetTypeConverterHandler() { throw null; }
        protected virtual bool LookupTrimSurroundingWhitespace() { throw null; }
        protected virtual System.Xaml.Schema.XamlValueConverter<System.ComponentModel.TypeConverter> LookupTypeConverter() { throw null; }
        protected virtual System.Type LookupUnderlyingType() { throw null; }
        protected virtual bool LookupUsableDuringInitialization() { throw null; }
        protected virtual System.Xaml.Schema.XamlValueConverter<System.Windows.Markup.ValueSerializer> LookupValueSerializer() { throw null; }
        public static bool operator ==(System.Xaml.XamlType xamlType1, System.Xaml.XamlType xamlType2) { throw null; }
        public static bool operator !=(System.Xaml.XamlType xamlType1, System.Xaml.XamlType xamlType2) { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class XamlWriter : System.IDisposable
    {
        protected XamlWriter() { }
        protected bool IsDisposed { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public abstract System.Xaml.XamlSchemaContext SchemaContext { get; }
        public void Close() { }
        protected virtual void Dispose(bool disposing) { }
        void System.IDisposable.Dispose() { }
        public abstract void WriteEndMember();
        public abstract void WriteEndObject();
        public abstract void WriteGetObject();
        public abstract void WriteNamespace(System.Xaml.NamespaceDeclaration namespaceDeclaration);
        public void WriteNode(System.Xaml.XamlReader reader) { }
        public abstract void WriteStartMember(System.Xaml.XamlMember xamlMember);
        public abstract void WriteStartObject(System.Xaml.XamlType type);
        public abstract void WriteValue(object value);
    }
    public partial class XamlWriterSettings
    {
        public XamlWriterSettings() { }
        public XamlWriterSettings(System.Xaml.XamlWriterSettings settings) { }
    }
    public partial class XamlXmlReader : System.Xaml.XamlReader, System.Xaml.IXamlLineInfo
    {
        public XamlXmlReader(System.IO.Stream stream) { }
        public XamlXmlReader(System.IO.Stream stream, System.Xaml.XamlSchemaContext schemaContext) { }
        public XamlXmlReader(System.IO.Stream stream, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.XamlXmlReaderSettings settings) { }
        public XamlXmlReader(System.IO.Stream stream, System.Xaml.XamlXmlReaderSettings settings) { }
        public XamlXmlReader(System.IO.TextReader textReader) { }
        public XamlXmlReader(System.IO.TextReader textReader, System.Xaml.XamlSchemaContext schemaContext) { }
        public XamlXmlReader(System.IO.TextReader textReader, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.XamlXmlReaderSettings settings) { }
        public XamlXmlReader(System.IO.TextReader textReader, System.Xaml.XamlXmlReaderSettings settings) { }
        public XamlXmlReader(string fileName) { }
        public XamlXmlReader(string fileName, System.Xaml.XamlSchemaContext schemaContext) { }
        public XamlXmlReader(string fileName, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.XamlXmlReaderSettings settings) { }
        public XamlXmlReader(string fileName, System.Xaml.XamlXmlReaderSettings settings) { }
        public XamlXmlReader(System.Xml.XmlReader xmlReader) { }
        public XamlXmlReader(System.Xml.XmlReader xmlReader, System.Xaml.XamlSchemaContext schemaContext) { }
        public XamlXmlReader(System.Xml.XmlReader xmlReader, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.XamlXmlReaderSettings settings) { }
        public XamlXmlReader(System.Xml.XmlReader xmlReader, System.Xaml.XamlXmlReaderSettings settings) { }
        public bool HasLineInfo { get { throw null; } }
        public override bool IsEof { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public int LinePosition { get { throw null; } }
        public override System.Xaml.XamlMember Member { get { throw null; } }
        public override System.Xaml.NamespaceDeclaration Namespace { get { throw null; } }
        public override System.Xaml.XamlNodeType NodeType { get { throw null; } }
        public override System.Xaml.XamlSchemaContext SchemaContext { get { throw null; } }
        public override System.Xaml.XamlType Type { get { throw null; } }
        public override object Value { get { throw null; } }
        public override bool Read() { throw null; }
    }
    public partial class XamlXmlReaderSettings : System.Xaml.XamlReaderSettings
    {
        public XamlXmlReaderSettings() { }
        public XamlXmlReaderSettings(System.Xaml.XamlXmlReaderSettings settings) { }
        public bool CloseInput { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool SkipXmlCompatibilityProcessing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string XmlLang { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool XmlSpacePreserve { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class XamlXmlWriter : System.Xaml.XamlWriter
    {
        public XamlXmlWriter(System.IO.Stream stream, System.Xaml.XamlSchemaContext schemaContext) { }
        public XamlXmlWriter(System.IO.Stream stream, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.XamlXmlWriterSettings settings) { }
        public XamlXmlWriter(System.IO.TextWriter textWriter, System.Xaml.XamlSchemaContext schemaContext) { }
        public XamlXmlWriter(System.IO.TextWriter textWriter, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.XamlXmlWriterSettings settings) { }
        public XamlXmlWriter(System.Xml.XmlWriter xmlWriter, System.Xaml.XamlSchemaContext schemaContext) { }
        public XamlXmlWriter(System.Xml.XmlWriter xmlWriter, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.XamlXmlWriterSettings settings) { }
        public override System.Xaml.XamlSchemaContext SchemaContext { get { throw null; } }
        public System.Xaml.XamlXmlWriterSettings Settings { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        public void Flush() { }
        public override void WriteEndMember() { }
        public override void WriteEndObject() { }
        public override void WriteGetObject() { }
        public override void WriteNamespace(System.Xaml.NamespaceDeclaration namespaceDeclaration) { }
        public override void WriteStartMember(System.Xaml.XamlMember property) { }
        public override void WriteStartObject(System.Xaml.XamlType type) { }
        public override void WriteValue(object value) { }
    }
    [System.SerializableAttribute]
    public partial class XamlXmlWriterException : System.Xaml.XamlException
    {
        public XamlXmlWriterException() { }
        protected XamlXmlWriterException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XamlXmlWriterException(string message) { }
        public XamlXmlWriterException(string message, System.Exception innerException) { }
    }
    public partial class XamlXmlWriterSettings : System.Xaml.XamlWriterSettings
    {
        public XamlXmlWriterSettings() { }
        public bool AssumeValidInput { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool CloseOutput { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Xaml.XamlXmlWriterSettings Copy() { throw null; }
    }
}
namespace System.Xaml.Permissions
{
    [System.SerializableAttribute]
    public partial class XamlAccessLevel
    {
        internal XamlAccessLevel() { }
        public System.Reflection.AssemblyName AssemblyAccessToAssemblyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string PrivateAccessToTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.Permissions.XamlAccessLevel AssemblyAccessTo(System.Reflection.Assembly assembly) { throw null; }
        public static System.Xaml.Permissions.XamlAccessLevel AssemblyAccessTo(System.Reflection.AssemblyName assemblyName) { throw null; }
        public static System.Xaml.Permissions.XamlAccessLevel PrivateAccessTo(string assemblyQualifiedTypeName) { throw null; }
        public static System.Xaml.Permissions.XamlAccessLevel PrivateAccessTo(System.Type type) { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class XamlLoadPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public XamlLoadPermission(System.Collections.Generic.IEnumerable<System.Xaml.Permissions.XamlAccessLevel> allowedAccess) { }
        public XamlLoadPermission(System.Security.Permissions.PermissionState state) { }
        public XamlLoadPermission(System.Xaml.Permissions.XamlAccessLevel allowedAccess) { }
        public System.Collections.Generic.IList<System.Xaml.Permissions.XamlAccessLevel> AllowedAccess { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement elem) { }
        public bool Includes(System.Xaml.Permissions.XamlAccessLevel requestedAccess) { throw null; }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission other) { throw null; }
    }
}
namespace System.Xaml.Schema
{
    [System.FlagsAttribute]
    public enum AllowedMemberLocations
    {
        Any = 3,
        Attribute = 1,
        MemberElement = 2,
        None = 0,
    }
    public enum ShouldSerializeResult
    {
        Default = 0,
        False = 2,
        True = 1,
    }
    public enum XamlCollectionKind : byte
    {
        Array = (byte)3,
        Collection = (byte)1,
        Dictionary = (byte)2,
        None = (byte)0,
    }
    public partial class XamlMemberInvoker
    {
        protected XamlMemberInvoker() { }
        public XamlMemberInvoker(System.Xaml.XamlMember member) { }
        public System.Reflection.MethodInfo UnderlyingGetter { get { throw null; } }
        public System.Reflection.MethodInfo UnderlyingSetter { get { throw null; } }
        public static System.Xaml.Schema.XamlMemberInvoker UnknownInvoker { get { throw null; } }
        public virtual object GetValue(object instance) { throw null; }
        public virtual void SetValue(object instance, object value) { }
        public virtual System.Xaml.Schema.ShouldSerializeResult ShouldSerializeValue(object instance) { throw null; }
    }
    public partial class XamlTypeInvoker
    {
        protected XamlTypeInvoker() { }
        public XamlTypeInvoker(System.Xaml.XamlType type) { }
        public System.EventHandler<System.Windows.Markup.XamlSetMarkupExtensionEventArgs> SetMarkupExtensionHandler { get { throw null; } }
        public System.EventHandler<System.Windows.Markup.XamlSetTypeConverterEventArgs> SetTypeConverterHandler { get { throw null; } }
        public static System.Xaml.Schema.XamlTypeInvoker UnknownInvoker { get { throw null; } }
        public virtual void AddToCollection(object instance, object item) { }
        public virtual void AddToDictionary(object instance, object key, object item) { }
        public virtual object CreateInstance(object[] arguments) { throw null; }
        public virtual System.Reflection.MethodInfo GetAddMethod(System.Xaml.XamlType contentType) { throw null; }
        public virtual System.Reflection.MethodInfo GetEnumeratorMethod() { throw null; }
        public virtual System.Collections.IEnumerator GetItems(object instance) { throw null; }
    }
    public partial class XamlTypeName
    {
        public XamlTypeName() { }
        public XamlTypeName(string xamlNamespace, string name) { }
        public XamlTypeName(string xamlNamespace, string name, System.Collections.Generic.IEnumerable<System.Xaml.Schema.XamlTypeName> typeArguments) { }
        public XamlTypeName(System.Xaml.XamlType xamlType) { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Namespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.Generic.IList<System.Xaml.Schema.XamlTypeName> TypeArguments { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Xaml.Schema.XamlTypeName Parse(string typeName, System.Xaml.IXamlNamespaceResolver namespaceResolver) { throw null; }
        public static System.Collections.Generic.IList<System.Xaml.Schema.XamlTypeName> ParseList(string typeNameList, System.Xaml.IXamlNamespaceResolver namespaceResolver) { throw null; }
        public override string ToString() { throw null; }
        public static string ToString(System.Collections.Generic.IList<System.Xaml.Schema.XamlTypeName> typeNameList, System.Xaml.INamespacePrefixLookup prefixLookup) { throw null; }
        public string ToString(System.Xaml.INamespacePrefixLookup prefixLookup) { throw null; }
        public static bool TryParse(string typeName, System.Xaml.IXamlNamespaceResolver namespaceResolver, out System.Xaml.Schema.XamlTypeName result) { result = default(System.Xaml.Schema.XamlTypeName); throw null; }
        public static bool TryParseList(string typeNameList, System.Xaml.IXamlNamespaceResolver namespaceResolver, out System.Collections.Generic.IList<System.Xaml.Schema.XamlTypeName> result) { result = default(System.Collections.Generic.IList<System.Xaml.Schema.XamlTypeName>); throw null; }
    }
    public partial class XamlTypeTypeConverter : System.ComponentModel.TypeConverter
    {
        public XamlTypeTypeConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
    }
    public partial class XamlValueConverter<TConverterBase> : System.IEquatable<System.Xaml.Schema.XamlValueConverter<TConverterBase>> where TConverterBase : class
    {
        public XamlValueConverter(System.Type converterType, System.Xaml.XamlType targetType) { }
        public XamlValueConverter(System.Type converterType, System.Xaml.XamlType targetType, string name) { }
        public TConverterBase ConverterInstance { get { throw null; } }
        public System.Type ConverterType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Xaml.XamlType TargetType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected virtual TConverterBase CreateInstance() { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Xaml.Schema.XamlValueConverter<TConverterBase> other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Xaml.Schema.XamlValueConverter<TConverterBase> converter1, System.Xaml.Schema.XamlValueConverter<TConverterBase> converter2) { throw null; }
        public static bool operator !=(System.Xaml.Schema.XamlValueConverter<TConverterBase> converter1, System.Xaml.Schema.XamlValueConverter<TConverterBase> converter2) { throw null; }
        public override string ToString() { throw null; }
    }
}