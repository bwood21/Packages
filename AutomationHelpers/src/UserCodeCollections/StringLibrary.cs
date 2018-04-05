﻿//
// Copyright © 2018 Ranorex All rights reserved
//

using System;
using Ranorex.Core.Testing;

namespace Ranorex.AutomationHelpers.UserCodeCollections
{
    /// <summary>
    /// A collection of string helper methods.
    /// </summary>
    [UserCodeCollection]
    public static class StringLibrary
    {
        /// <summary>
        /// Concatenates two strings and returns the new string.
        /// </summary>
        /// <param name="value1">First string</param>
        /// <param name="value2">Second string</param>
        /// <returns>Concatenated string</returns>
        [UserCodeMethod]
        public static string ConcatStrings(string value1, string value2)
        {
            return String.Concat(value1, value2);
        }

        /// <summary>
        /// Creates and returns a random string. If a string shorter than 35 characters is used it may not be unique.
        /// </summary>
        /// <param name="length">Expected length of the return value (default length is 35)</param>
        /// <returns>Random string</returns>
        [UserCodeMethod]
        public static string GetRandomString(string length = "35")
        {
            string returnValue = "";
            Int32 len = Int32.Parse(length);

            if (len > 35)
            {
                returnValue = GetRandomString((len - 36).ToString());
                return returnValue + Guid.NewGuid().ToString();
            }
            else
            {
                returnValue = Guid.NewGuid().ToString().Substring(0, len);
            }

            return returnValue;
        }
    }
}
