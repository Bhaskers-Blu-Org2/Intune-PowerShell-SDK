// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.publicationFacet&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.publicationFacet&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "PublicationFacetObject", DefaultParameterSetName = @"microsoft.graph.publicationFacet")]
    [ODataType("microsoft.graph.publicationFacet")]
    public class New_PublicationFacetObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;level&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.publicationFacet&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.publicationFacet", HelpMessage = @"The &quot;level&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String level { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;versionId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.publicationFacet&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.publicationFacet", HelpMessage = @"The &quot;versionId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String versionId { get; set; }
    }
}