﻿using Nanologger.Entities;

namespace Nanologger.Format
{
    /// <summary>
    /// This interface provides abstraction to the formatting procedure.
    /// Implement this interface and define a behaviour about how the logging information should be represented.
    /// </summary>
    public interface ILogStringFormat
    {
        /// <summary>
        /// Returns a formatted string with a given logging information object.
        /// </summary>
        /// <param name="logInfo">The required logging information object.</param>
        /// <returns>The formatted string.</returns>
        string Format(LogInfo logInfo);
    }
}