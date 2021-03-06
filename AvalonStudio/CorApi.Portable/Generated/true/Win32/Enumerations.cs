// Copyright (c) 2010-2014 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

//------------------------------------------------------------------------------
// <auto-generated>
//     Types declaration for CorApi.Portable.Win32 namespace.
//     This code was generated by a tool.
//     Date : 11/05/2017 11:23:35
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
#if true
namespace CorApi.Portable.Win32 {

#pragma warning disable 419
#pragma warning disable 1587
#pragma warning disable 1574
    
    /// <summary>	
    /// No documentation.	
    /// </summary>	
    /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='STGC']/*"/>	
    /// <unmanaged>STGC</unmanaged>	
    /// <unmanaged-short>STGC</unmanaged-short>	
    [Flags]
    public enum CommitFlags : int {	
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='STGC_DEFAULT']/*"/>	
        /// <unmanaged>STGC_DEFAULT</unmanaged>	
        /// <unmanaged-short>STGC_DEFAULT</unmanaged-short>	
        Default = unchecked((int)0),			
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='STGC_OVERWRITE']/*"/>	
        /// <unmanaged>STGC_OVERWRITE</unmanaged>	
        /// <unmanaged-short>STGC_OVERWRITE</unmanaged-short>	
        Overwrite = unchecked((int)1),			
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='STGC_ONLYIFCURRENT']/*"/>	
        /// <unmanaged>STGC_ONLYIFCURRENT</unmanaged>	
        /// <unmanaged-short>STGC_ONLYIFCURRENT</unmanaged-short>	
        OnlyCurrent = unchecked((int)2),			
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='STGC_DANGEROUSLYCOMMITMERELYTODISKCACHE']/*"/>	
        /// <unmanaged>STGC_DANGEROUSLYCOMMITMERELYTODISKCACHE</unmanaged>	
        /// <unmanaged-short>STGC_DANGEROUSLYCOMMITMERELYTODISKCACHE</unmanaged-short>	
        DangerouslyCommitMerelyToDiskCache = unchecked((int)4),			
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='STGC_CONSOLIDATE']/*"/>	
        /// <unmanaged>STGC_CONSOLIDATE</unmanaged>	
        /// <unmanaged-short>STGC_CONSOLIDATE</unmanaged-short>	
        Consolidate = unchecked((int)8),			
    }
    
    /// <summary>	
    /// No documentation.	
    /// </summary>	
    /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='LOCKTYPE']/*"/>	
    /// <unmanaged>LOCKTYPE</unmanaged>	
    /// <unmanaged-short>LOCKTYPE</unmanaged-short>	
    [Flags]
    public enum LockType : int {	
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='LOCK_WRITE']/*"/>	
        /// <unmanaged>LOCK_WRITE</unmanaged>	
        /// <unmanaged-short>LOCK_WRITE</unmanaged-short>	
        Write = unchecked((int)1),			
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='LOCK_EXCLUSIVE']/*"/>	
        /// <unmanaged>LOCK_EXCLUSIVE</unmanaged>	
        /// <unmanaged-short>LOCK_EXCLUSIVE</unmanaged-short>	
        Exclusive = unchecked((int)2),			
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='LOCK_ONLYONCE']/*"/>	
        /// <unmanaged>LOCK_ONLYONCE</unmanaged>	
        /// <unmanaged-short>LOCK_ONLYONCE</unmanaged-short>	
        OnlyOnce = unchecked((int)4),			
    }
    
    /// <summary>	
    /// No documentation.	
    /// </summary>	
    /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='STATFLAG']/*"/>	
    /// <unmanaged>STATFLAG</unmanaged>	
    /// <unmanaged-short>STATFLAG</unmanaged-short>	
    [Flags]
    public enum StorageStatisticsFlags : int {	
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='STATFLAG_DEFAULT']/*"/>	
        /// <unmanaged>STATFLAG_DEFAULT</unmanaged>	
        /// <unmanaged-short>STATFLAG_DEFAULT</unmanaged-short>	
        Default = unchecked((int)0),			
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='STATFLAG_NONAME']/*"/>	
        /// <unmanaged>STATFLAG_NONAME</unmanaged>	
        /// <unmanaged-short>STATFLAG_NONAME</unmanaged-short>	
        NoName = unchecked((int)1),			
        
        /// <summary>	
        /// None.	
        /// </summary>	
        /// <include file='..\..\Documentation\CodeComments.xml' path="/comments/comment[@id='']/*"/>	
        /// <unmanaged>None</unmanaged>	
        /// <unmanaged-short>None</unmanaged-short>	
        None = unchecked((int)0),			
    }
}
#endif
