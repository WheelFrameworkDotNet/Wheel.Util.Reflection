using System;
using System.Collections;
using System.Collections.Generic;
using Wheel.Core.Exceptions;
using Wheel.Util.Core.Exceptions;

namespace Wheel.Util.Reflection.TypeScope
{
    /// <summary>
    /// Utilitario de reflexión con alcance Type.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <h2 class="groupheader">Registro de versiones</h2>
    ///         <ul>
    ///             <li>1.0.0</li>
    ///             <table>
    ///                 <tr style="font-weight: bold;">
    ///                     <td>Autor</td>
    ///                     <td>Fecha</td>
    ///                     <td>Descripción</td>
    ///                 </tr>
    ///                 <tr>
    ///                     <td>Marcos Abraham Hernández Bravo.</td>
    ///                     <td>07/11/2016</td>
    ///                     <td>Versión Inicial.</td>
    ///                 </tr>
    ///             </table>
    ///         </ul>
    ///     </para>
    /// </remarks>
    public static partial class ReflectionUtil
    {
        /// <summary>
        /// Comprueba si tipo es creado por el usuario (no primitivo) o de C#(primitivo).
        /// Para ello utiliza el <see cref="TypeCode"/> (TypeCode.Object) del tipo y de los argumentos genéricos.
        /// De ser colección comprueba que el tipo de la colección, sea primitiva también.
        /// Si se trata de un diccionario comprueba ambos tipos genéricos recursivamente.
        /// <example>
        ///     typeof(bool)                 --> Primitivo
        ///     typeof(string)               --> Primitivo
        ///     typeof(String)               --> Primitivo
        ///     typeof(UsuarioTO)            --> No primitivo.
        /// </example>
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <exception cref="UtilException">Es lanzado al ocurrir una excepción en tiempo de ejecución de cualquier tipo.</exception>
        /// <param name="_tipo">Tipo a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsPrimitivo(this Type _tipo)
        {
            try
            {
                if (_tipo == null)
                {
                    throw new ArgumentNullException("_tipo", ArgumentoInvalido.NULO.Descripcion);
                }

                TypeCode codigoTipo = Type.GetTypeCode(_tipo);

                if (_tipo.EsDiccionario())
                {
                    Type[] argumentos = _tipo.GetGenericArguments();
                    return argumentos[0].EsPrimitivo() && argumentos[1].EsPrimitivo();
                }

                if (_tipo.EsColeccion())
                {
                    Type tipoSingular = Type.GetType(_tipo.ObtenerTipoSingular());
                    return tipoSingular.EsPrimitivo();
                }
                
                return codigoTipo != TypeCode.Object;
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un tipo es <see cref="IDictionary"/>.
        /// Para ello comprueba si el tipo es asignable a <see cref="IDictionary"/>, si contiene 2 argumentos genéricos
        /// y si el nombre del tipo contiene "dictionary";
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <exception cref="UtilException">Es lanzado al ocurrir una excepción en tiempo de ejecución de cualquier tipo.</exception>
        /// <param name="_tipo">Tipo a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsDiccionario(this Type _tipo)
        {
            try
            {
                if (_tipo == null)
                {
                    throw new ArgumentNullException("_tipo", ArgumentoInvalido.NULO.Descripcion);
                }

                bool retorno = typeof(IDictionary).IsAssignableFrom(_tipo);

                if (!retorno)
                {
                    return _tipo.GetGenericArguments().Length == 2 && _tipo.Name.ToLower().Contains("dictionary");
                }

                return retorno;
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un tipo es un Enum.
        /// Para ello comprueba que el tipo sea <see cref="Enum"/> o el tipo base de éste, lo sea.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <exception cref="UtilException">Es lanzado al ocurrir una excepción en tiempo de ejecución de cualquier tipo.</exception>
        /// <param name="_tipo">Tipo a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsEnumeracion(this Type _tipo)
        {
            try
            {
                if (_tipo == null)
                {
                    throw new ArgumentNullException("_tipo", ArgumentoInvalido.NULO.Descripcion);
                }

                return _tipo == typeof(Enum) || _tipo.BaseType == typeof(Enum);
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un tipo es una colección.
        /// Descartando a un string, comprueba si el tipo es asignable a <see cref="System.Collections.IEnumerable"/>.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <exception cref="UtilException">Es lanzado al ocurrir una excepción en tiempo de ejecución de cualquier tipo.</exception>
        /// <param name="_tipo">Tipo a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsColeccion(this Type _tipo)
        {
            try
            {
                if (_tipo == null)
                {
                    throw new ArgumentNullException("_tipo", ArgumentoInvalido.NULO.Descripcion);
                }

                if (_tipo.Name.ToLower().Contains("string") && !_tipo.Name.Contains("List") && !_tipo.Name.Contains("[") && !_tipo.Name.Contains("]"))
                {
                    return false;
                }

                bool retorno = typeof(IEnumerable).IsAssignableFrom(_tipo);

                if (!retorno)
                {
                    if (_tipo.IsGenericTypeDefinition)
                    {
                        retorno = typeof(IEnumerable).IsAssignableFrom(_tipo.GetGenericTypeDefinition())
                                    || typeof(IEnumerable<>).IsAssignableFrom(_tipo.GetGenericTypeDefinition());
                    }
                }

                return typeof(IEnumerable).IsAssignableFrom(_tipo);
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un tipo es string. Opcionalmente ofrece que interprete un char como string o no.
        /// Por defecto no se toma un char como string.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <exception cref="UtilException">Es lanzado al ocurrir una excepción en tiempo de ejecución de cualquier tipo.</exception>
        /// <param name="_tipo">Tipo a comprobar.</param>
        /// <param name="_incluirChar">Indica si se debe tratar a un char como un string. [Opcional]</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsString(this Type _tipo, bool _incluirChar = false)
        {
            try
            {
                if (_tipo == null)
                {
                    throw new ArgumentNullException("_tipo", ArgumentoInvalido.NULO.Descripcion);
                }

                if (_incluirChar)
                {
                    return typeof(string) == _tipo || typeof(char) == _tipo;
                }
                return typeof(string) == _tipo;
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un tipo es un decimal.
        /// Para ello recurre al <see cref="TypeCode"/> en cuyo caso considera como decimales:
        ///     - TypeCode.Decimal
        ///     - TypeCode.Double
        ///     - TypeCode.Single.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <exception cref="UtilException">Es lanzado al ocurrir una excepción en tiempo de ejecución de cualquier tipo.</exception>
        /// <param name="_tipo">Tipo a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsDecimal(this Type _tipo)
        {
            try
            {
                if (_tipo == null)
                {
                    throw new ArgumentNullException("_tipo", ArgumentoInvalido.NULO.Descripcion);
                }

                switch (Type.GetTypeCode(_tipo))
                {
                    case TypeCode.Decimal:
                    case TypeCode.Double:
                    case TypeCode.Single:
                        return true;
                    default:
                        return false;
                }
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un tipo es bool.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <exception cref="UtilException">Es lanzado al ocurrir una excepción en tiempo de ejecución de cualquier tipo.</exception>
        /// <param name="_tipo">Tipo a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsBooleano(this Type _tipo)
        {
            try
            {
                if (_tipo == null)
                {
                    throw new ArgumentNullException("_tipo", ArgumentoInvalido.NULO.Descripcion);
                }

                return typeof(bool) == _tipo;
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un tipo es numérico.
        /// Para ello recurre al <see cref="TypeCode"/> en cuyo caso considera como números:
        ///     - TypeCode.Byte
        ///     - TypeCode.SByte
        ///     - TypeCode.UInt16
        ///     - TypeCode.UInt32
        ///     - TypeCode.UInt64
        ///     - TypeCode.Int16
        ///     - TypeCode.Int32
        ///     - TypeCode.Int64
        ///     - TypeCode.Decimal
        ///     - TypeCode.Double
        ///     - TypeCode.Single 
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <exception cref="UtilException">Es lanzado al ocurrir una excepción en tiempo de ejecución de cualquier tipo.</exception>
        /// <param name="_tipo">Tipo a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsNumero(this Type _tipo)
        {
            try
            {
                if (_tipo == null)
                {
                    throw new ArgumentNullException("_tipo", ArgumentoInvalido.NULO.Descripcion);
                }

                switch (Type.GetTypeCode(_tipo))
                {
                    case TypeCode.Byte:
                    case TypeCode.SByte:
                    case TypeCode.UInt16:
                    case TypeCode.UInt32:
                    case TypeCode.UInt64:
                    case TypeCode.Int16:
                    case TypeCode.Int32:
                    case TypeCode.Int64:
                    case TypeCode.Decimal:
                    case TypeCode.Double:
                    case TypeCode.Single:
                        return true;
                    default:
                        return false;
                }
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Obtiene el tipo (AssemblyQualifiedName) en singular de un tipo que sea una colección.
        /// Llama a OtherScope con la AssemblyQualifiedName del tipo.
        /// <example>
        ///     string tS = TipoSingular(typeof(IList of UsuarioTO));
        ///         - ts es entonces UsuarioTO.
        /// </example>
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <exception cref="UtilException">Es lanzado al ocurrir una excepción en tiempo de ejecución de cualquier tipo.</exception>
        /// <param name="_tipo">Tipo a comprobar.</param>
        /// <returns>AssemblyQualifiedName del tipo en singular.</returns>
        public static string ObtenerTipoSingular(this Type _tipo)
        {
            try
            {
                if (_tipo == null)
                {
                    throw new ArgumentNullException("_tipo", ArgumentoInvalido.NULO.Descripcion);
                }

                return OtherScope.ReflectionUtil.ObtenerTipoSingular(_tipo.AssemblyQualifiedName);
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Obtiene una nueva instancia del tipo especificado.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <param name="_tipo">Tipo de la instancia.</param>
        /// <param name="_parametros">Array de parametros del contructor de ese tipo.</param>
        /// <returns></returns>
        public static object CrearInstancia(this Type _tipo, object[] _parametros = null)
        {
            try
            {
                if (_tipo == null)
                {
                    throw new ArgumentNullException("_tipo", ArgumentoInvalido.NULO.Descripcion);
                }

                if (_parametros == null)
                {
                    return Activator.CreateInstance(_tipo);
                }
                return Activator.CreateInstance(_tipo, _parametros);
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }
    }
}
