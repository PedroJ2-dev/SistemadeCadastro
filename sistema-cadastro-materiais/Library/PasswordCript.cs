using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_cadastro_materiais.Library
{
    public static class PasswordCript
    {
        public static string Criptografar(string informacao, string chave)
        {
            var codificado = EncodeTo64(informacao);

            var codificarComChave = string.Concat(chave, "=====", codificado);

            var codificado2X = EncodeTo64(codificarComChave);

            return EncodeTo64(codificado2X);

        }

        static private string DecodeFrom64(string encodeData)
        {
            byte[] encodeDataAsByte = System.Convert.FromBase64String(encodeData);

            string returnValue = System.Text.ASCIIEncoding.UTF8.GetString(encodeDataAsByte);

            return returnValue;
        }

        static private string EncodeTo64(string toEncode)
        {
            byte[] toEncodeAsByte = System.Text.ASCIIEncoding.UTF8.GetBytes(toEncode);

            string returnValue = System.Convert.ToBase64String(toEncodeAsByte);

            return returnValue;
        }

        public static string DesCriptografar(string informacao, string chave)
        {

            try
            {

                var decodificar = DecodeFrom64(informacao);

                var decodificar2XInformacaoCompleta = DecodeFrom64(decodificar);

                String[] separador = { "=====" };
                Int32 count = 2;
                var separadorInformacao = decodificar2XInformacaoCompleta.Split(separador, count, StringSplitOptions.None);

                if (separadorInformacao[0].ToString() == chave)
                {
                    return DecodeFrom64(separadorInformacao[1].ToString());
                }

            }
            catch (Exception)
            {

            }

            return string.Empty;

        }
    }
}
