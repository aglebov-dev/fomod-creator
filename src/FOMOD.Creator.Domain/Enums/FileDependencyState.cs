namespace FOMOD.Creator.Domain.Enums
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    ///     The possible file state types.
    /// </summary>
    [Serializable]
    [XmlType("fileDependencyState", AnonymousType = true)]
    public enum FileDependencyState
    {
        /// <summary>
        ///     Indicates the mod file is not installed.
        /// </summary>
        Missing,

        /// <summary>
        ///     Indicates the mod file is installed, but not active.
        /// </summary>
        Inactive,

        /// <summary>
        ///     Indicates the mod file is installed and active.
        /// </summary>
        Active
    }
}
