//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GSB_TAC
{
    using System;
    using System.Collections.Generic;
    
    public partial class MEDECIN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEDECIN()
        {
            this.RAPPORT = new HashSet<RAPPORT>();
        }
    
        public int idMedecin { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adresse { get; set; }
        public string tel { get; set; }
        public string idSpecialite { get; set; }
        public int departement { get; set; }
    
        public virtual SPECIALITE SPECIALITE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RAPPORT> RAPPORT { get; set; }
    }
}
