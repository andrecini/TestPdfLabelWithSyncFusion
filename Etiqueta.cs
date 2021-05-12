using System;
using System.Collections.Generic;
using System.IO;

namespace TesteCriarPdfEmRuntimeWithSyncFusion
{
    public class Etiqueta
    {
        #region Singleton

        private static Etiqueta _instance;

        /// <summary>
        /// Gera apenas uma instância do Objeto Etiqueta
        /// </summary>
        /// <param name="function">Função</param>
        /// <param name="tag">Tag</param>
        /// <param name="date">Data</param>
        /// <param name="validity">Validade</param>
        /// <param name="executor">Executante</param>
        /// <returns>Instância única do objeto Etiqueta</returns>
        public static Etiqueta GetSingleInstance(int ID, string function, string tag, string date, string validity, string executor, string logo)
        { 
            if(_instance == null)
                _instance = new Etiqueta(ID, function, tag, date, validity, executor, logo);

            return _instance;
        }

        /// <summary>
        /// Gera apenas uma instância do Objeto Etiqueta
        /// </summary>
        /// <param name="tagData">
        /// String[6]
        /// [0] - Funcão
        /// [1] - Funcão
        /// [2] - Tag
        /// [3] - Data
        /// [4] - Validade
        /// [5] - Executante
        /// [6] - Path imagem Logo
        /// </param>
        /// <returns>Instância única do objeto Etiqueta</returns>
        public static Etiqueta GetSingleInstance(string[] tagData)
        {
            if (_instance == null)
                _instance = new Etiqueta(tagData);

            return _instance;
        }

        /// <summary>
        ///  Gera apenas uma instância do Objeto Etiqueta.
        /// </summary>
        /// <param name="tagData">
        /// Lista de String
        /// [0] - Funcão
        /// [1] - Funcão
        /// [2] - Tag
        /// [3] - Data
        /// [4] - Validade
        /// [5] - Executante
        /// [6] - Path imagem Logo
        /// </param>
        /// <returns>Instância única do objeto Etiqueta</returns>
        public static Etiqueta GetSingleInstance(List<string> tagData)
        {
            if (_instance == null)
                _instance = new Etiqueta(tagData);

            return _instance;
        }

        /// <summary>
        ///  Gera apenas uma instância do Objeto Etiqueta.
        /// </summary>
        /// <returns>Instância única do objeto Etiqueta</returns>
        public static Etiqueta GetSingleInstance()
        {
            if (_instance == null)
                _instance = new Etiqueta();

            return _instance;
        }

        /// <summary>
        /// Gera apenas uma instância do objeto Etiqueta e deve ser utilizado apenas p
        /// </summary>
        /// <returns>Instância única do objeto Etiqueta</returns>
        public static bool CheckIfAnInstanceExists()
        {
            if (_instance == null)
            { 
                 return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        #region Construtores Personalizados

        /// <summary>
        /// Construtor com string passadas como parâmetro
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="function">Função</param>
        /// <param name="tag">Tag</param>
        /// <param name="date">Data</param>
        /// <param name="validity">Validade</param>
        /// <param name="executor">Executante</param>
        /// <param name="logo">Path da imagem Logo</param>
        private Etiqueta(int ID, string function, string tag, string date, string validity, string executor, string logo)
        {
            Function = function;
            Tag = tag;
            Date = date;
            Validity = validity;
            Executor = executor;
            Logo = logo;

            _instance = this;
        }

        /// <summary>
        /// Construtor com Array de Strings passados como parâmetro.
        /// </summary>
        /// <param name="tagData">
        /// [0] - ID
        /// [1] - Funcão
        /// [2] - Tag
        /// [3] - Data
        /// [4] - Validade
        /// [5] - Executante
        /// [6] - Path da imagem Logo
        /// </param>
        private Etiqueta(string[] tagData)
        {
            if(tagData.Length != 7)
                throw new Exception("O vetor informado deve possuir exatamente 6 posições.");
            else
            {
                ID = int.Parse(tagData[0]);
                Function = tagData[1];
                Tag = tagData[2];
                Date = tagData[3];
                Validity = tagData[4];
                Executor = tagData[5];
                Logo = tagData[6];
            }

            _instance = this;
        }

        /// <summary>
        /// Construtor com Lista de Strings passados como parâmetro.
        /// </summary>
        /// <param name="tagData">
        /// [0] - ID
        /// [1] - Funcão
        /// [2] - Tag
        /// [3] - Data
        /// [4] - Validade
        /// [5] - Executante
        /// [6] - Path da imagem Logo
        /// </param>
        private Etiqueta(List<string> tagData)
        {
            if (tagData.Count != 7)
                throw new Exception("O vetor informado deve possuir exatamente 6 posições.");
            else
            {
                ID = int.Parse(tagData[0]);
                Function = tagData[1];
                Tag = tagData[2];
                Date = tagData[3];
                Validity = tagData[4];
                Executor = tagData[5];
                Logo = tagData[6];
            }

            _instance = this;
        }

        /// <summary>
        /// Construtor Padrão
        /// </summary>
        private Etiqueta() { }

        #endregion

        #region Propriedades locais

        private int _id;
        private string  _function;
        private string _tag;
        private string _date;
        private string _validity;
        private string _executor;
        private string _logoPath;

        #endregion

        #region Propriedades Encapsuladas

        public int ID
        {
            get => _id;
            set
            {
                if(value < 0)
                    throw new Exception("O ID não pode receber um valor negativo.");
                else
                    _id = value;
            }
        }

        public string Function
        {
            get => _function;
            set
            {
                if (value == null || value == string.Empty)
                    throw new Exception("A string não podde ser nula nem vazia.");
                if (value.Length > 12)
                    throw new Exception("ERRO: O limite de caracteres para cada campo é de 12 posições.");
                else
                    _function = value.Trim();
            }
        }

        public string Tag 
        { 
            get => _tag;
            set
            {
                if (value == null || value == string.Empty)
                    throw new Exception("A string não podde ser nula nem vazia.");
                if (value.Length > 12)
                    throw new Exception("ERRO: O limite de caracteres para cada campo é de 12 posições.");
                else
                    _tag = value.Trim();
            }
        }

        public string Date 
        { 
            get => _date;
            set
            {
                if (value == null || value == string.Empty)
                    throw new Exception("A string não podde ser nula nem vazia.");
                if (value.Length > 12)
                    throw new Exception("ERRO: O limite de caracteres para cada campo é de 12 posições.");
                else
                    _date = value.Trim();
            }
        }

        public string Validity 
        {
            get => _validity;
            set
            {
                if (value == null || value == string.Empty)
                    throw new Exception("A string não podde ser nula nem vazia.");
                if (value.Length > 12)
                    throw new Exception("ERRO: O limite de caracteres para cada campo é de 12 posições.");
                else
                    _validity = value.Trim();
            }
        }

        public string Executor 
        { 
            get => _executor;
            set
            {
                if (value == null || value == string.Empty)
                    throw new Exception("A string não podde ser nula nem vazia.");
                if (value.Length > 12)
                    throw new Exception("ERRO: O limite de caracteres para cada campo é de 12 posições.");
                else
                    _executor = value.Trim();
            }
        }

        public string Logo 
        { 
            get => _logoPath;
            set 
            {
                if (value == null || value == string.Empty)
                    throw new Exception("A string não podde ser nula nem vazia.");
                else
                    _logoPath = value;
            }
        }

        #endregion
    }
}
