﻿/// <remarks>
/// Copyright (C) 2016 Squizz PTY LTD
/// This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
/// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
/// You should have received a copy of the GNU General Public License along with this program.  If not, see http://www.gnu.org/licenses/.
/// </remarks>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace EcommerceStandardsDocuments
{
    /// <summary>Ecommerce Standards Record that holds data for a single attribute profile associated with products. A profile allows any number of attributes to be grouped together.</summary>
    [DataContract]
    public class ESDRecordAttributeProfile
    {
        /// <summary>Key that allows the attribute record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyAttributeProfileID { get; set; }
        /// <summary>Name of the attribute</summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        /// <summary>Text that describes the attribute profile.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the price to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>List of attributes </summary>
        [DataMember(EmitDefaultValue = false)]
        public ESDRecordAttribute[] attributes { get; set; }
    }
}