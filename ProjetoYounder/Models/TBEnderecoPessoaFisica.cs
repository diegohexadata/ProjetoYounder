//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoYounder.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBEnderecoPessoaFisica
    {
        public int EnderecoPessoaFisica { get; set; }
        public Nullable<int> idpessoafisica { get; set; }
        public string logradouro { get; set; }
        public Nullable<short> numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
    }
}