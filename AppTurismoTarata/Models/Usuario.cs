namespace AppTurismoTarata.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        public int idUsuario { get; set; }

        [Required]
        [StringLength(100)]
        public string correo { get; set; }

        [Required]
        [StringLength(100)]
        public string clave { get; set; }

        //Metodos
        public ResponseModel Acceder(string Usuario, string Password)
        {
            var rm = new ResponseModel();

            try
            {

                using (var db = new TarataApp())
                {
                    Password = HashHelper.MD5(Password);

                    var usuario = db.Usuario.Where(x => x.correo == Usuario)
                                            .Where(x => x.clave == Password)
                                            .SingleOrDefault();

                    if (usuario != null)
                    {
                        SessionHelper.AddUserToSession(usuario.idUsuario.ToString());
                        rm.SetResponse(true);
                    }
                    else
                    {
                        rm.SetResponse(false, "Usuario y/o Password incorrectos...");
                    }
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            return rm;
        }
    }
}
