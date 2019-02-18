﻿// <copyright file="RecordState.cs" company="Gamma Four, Inc.">
//    Copyright © 2018 - Gamma Four, Inc.  All Rights Reserved.
// </copyright>
// <author>Donald Roy Airey</author>
namespace GammaFour.Data
{
    /// <summary>
    /// The different states of a record.
    /// </summary>
    public enum RecordState
    {
        /// <summary>
        /// The record has been added to a set.
        /// </summary>
        Added,

        /// <summary>
        /// The record has been modified.
        /// </summary>
        Modified,

        /// <summary>
        /// The record has been deleted.
        /// </summary>
        Deleted,

        /// <summary>
        /// The record is not part of a set.
        /// </summary>
        Detached,

        /// <summary>
        /// The record is unchanged.
        /// </summary>
        Unchanged
    }
}