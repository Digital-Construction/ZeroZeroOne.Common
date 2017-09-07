//
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
    public static class BooleanExtensions
    {
        /// <summary>
        /// Converts a boolean value to a string of Yes or No
        /// </summary>
        /// <param name="value">if set to <c>true</c> [value].</param>
        /// <returns></returns>
        public static String ToYesNo(this Boolean value)
        {
            return value.ToTrueFalseText("Yes", "No");
        }

        /// <summary>
        /// Converts a boolean value to a specified string for the true or false value
        /// </summary>
        /// <param name="value">if set to <c>true</c> [value].</param>
        /// <param name="trueText">The true text.</param>
        /// <param name="falseText">The false text.</param>
        /// <returns></returns>
        public static String ToTrueFalseText(this Boolean value, String trueText, String falseText)
        {
            return value ? trueText : falseText;
        }

    }
}
