//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PasteBookEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            this.COMMENTS = new HashSet<COMMENT>();
            this.COMMENTS1 = new HashSet<COMMENT>();
            this.LIKES = new HashSet<LIKE>();
            this.NOTIFICATIONs = new HashSet<NOTIFICATION>();
            this.NOTIFICATIONs1 = new HashSet<NOTIFICATION>();
            this.POSTS = new HashSet<POST>();
            this.POSTS1 = new HashSet<POST>();
            this.FRIENDS = new HashSet<FRIEND>();
            this.FRIENDS1 = new HashSet<FRIEND>();
        }
    
        public int ID { get; set; }
        public string USER_NAME { get; set; }
        public string PASSWORD { get; set; }
        public string SALT { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public System.DateTime BIRTHDATE { get; set; }
        public Nullable<int> COUNTRY_ID { get; set; }
        public string MOBILE_NO { get; set; }
        public string GENDER { get; set; }
        public byte[] PROFILE_PIC { get; set; }
        public System.DateTime DATE_CREATED { get; set; }
        public string ABOUT_ME { get; set; }
        public string EMAIL_ADDRESS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMMENT> COMMENTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMMENT> COMMENTS1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIKE> LIKES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIFICATION> NOTIFICATIONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIFICATION> NOTIFICATIONs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POST> POSTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POST> POSTS1 { get; set; }
        public virtual REF_COUNTRY REF_COUNTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FRIEND> FRIENDS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FRIEND> FRIENDS1 { get; set; }
    }
}