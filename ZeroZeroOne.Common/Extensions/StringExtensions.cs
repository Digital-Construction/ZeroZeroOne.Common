﻿//
//  Copyright 2017  Zero Zero One
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System;
namespace ZeroZeroOne.Common.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Determines whether this string has any characters.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if the specified value has value; otherwise, <c>false</c>.
        /// </returns>
        public static Boolean HasValue(this String value)
		{
			return !String.IsNullOrEmpty(value);
		}
    }
}
