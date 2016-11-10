using System;
using System.Reflection;
using Wheel.Util.Core.Exceptions;

namespace Wheel.Util.Reflection
{
    /// <summary>
    /// Utilitario de reflexión para objetos.
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
    public static class ReflectionUtil
    {
        /// <summary>
        /// Comprueba si un objeto, tipo o propiedad es creado por el usuario (no primitivo) o de C#(primitivo).
        /// </summary>
        /// <example>
        ///     bool a = false;                 --> Primitivo
        ///     string a = "Hola Mundo";        --> Primitivo
        ///     String a = String.Empty;        --> Primitivo
        ///     UsuarioTO a = new UsuarioTO();  --> No primitivo.
        /// </example>
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
        /// <param name="_objeto">Objeto, tipo o propiedad a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsPrimitivo(this object _objeto)
        {
            try
            {
                if (_objeto is Type)
                {
                    return TypeScope.ReflectionUtil.EsPrimitivo(_objeto as Type);
                }
                else if (_objeto is PropertyInfo)
                {
                    return InfoScope.ReflectionUtil.EsPrimitivo(_objeto as PropertyInfo);
                }
                else
                {
                    return ObjectScope.ReflectionUtil.EsPrimitivo(_objeto);
                }
            }
            catch(UtilException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw  new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un objeto, tipo o propiedad es de tipo colección.
        /// De ser un tipo, llama a TypeScope con _objeto as Type. Si es una propiedad, llama a InfoScope con _objeto as PropertyInfo.
        /// De lo contrario, llama a ObjectScope con el objeto.
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
        /// <param name="_objeto">Objeto, tipo o propiedad a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsColeccion(this object _objeto)
        {
            try
            {
                if (_objeto is Type)
                {
                    return  TypeScope.ReflectionUtil.EsColeccion(_objeto as Type);
                }
                else if (_objeto is PropertyInfo)
                {
                    return  InfoScope.ReflectionUtil.EsColeccion(_objeto as PropertyInfo);
                }
                else
                {
                    return  ObjectScope.ReflectionUtil.EsColeccion(_objeto);
                }
            }
            catch(UtilException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw  new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un objeto, tipo o propiedad es de tipo Enum.
        /// De ser un tipo, llama a TypeScope con _objeto as Type. Si es una propiedad, llama a InfoScope con _objeto as PropertyInfo.
        /// De lo contrario, llama a ObjectScope con el objeto.
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
        /// <param name="_objeto">Objeto, tipo o propiedad a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsEnumeracion(this object _objeto)
        {
            try
            {
                if (_objeto is Type)
                {
                    return  TypeScope.ReflectionUtil.EsEnumeracion(_objeto as Type);
                }
                else if (_objeto is PropertyInfo)
                {
                    return  InfoScope.ReflectionUtil.EsEnumeracion(_objeto as PropertyInfo);
                }
                else
                {
                    return  ObjectScope.ReflectionUtil.EsEnumeracion(_objeto);
                }
            }
            catch (UtilException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw  new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un objeto, tipo o propiedad es de tipo <see cref="System.Collections.IDictionary"/>.
        /// De ser un tipo, llama a TypeScope con _objeto as Type. Si es una propiedad, llama a InfoScope con _objeto as PropertyInfo.
        /// De lo contrario, llama a ObjectScope con el objeto.
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
        /// <param name="_objeto">Objeto, tipo o propiedad a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsDiccionario(this object _objeto)
        {
            try
            {
                if (_objeto is Type)
                {
                    return  TypeScope.ReflectionUtil.EsDiccionario(_objeto as Type);
                }
                else if (_objeto is PropertyInfo)
                {
                    return  InfoScope.ReflectionUtil.EsDiccionario(_objeto as PropertyInfo);
                }
                else
                {
                    return  ObjectScope.ReflectionUtil.EsDiccionario(_objeto);
                }
            }
            catch (UtilException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw  new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un objeto, tipo o propiedad es de tipo decimal.
        /// De ser un tipo, llama a TypeScope con _objeto as Type. Si es una propiedad, llama a InfoScope con _objeto as PropertyInfo.
        /// De lo contrario, llama a ObjectScope con el objeto.
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
        /// <param name="_objeto">Objeto, tipo o propiedad a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsDecimal(this object _objeto)
        {
            try
            {
                if (_objeto is Type)
                {
                    return  TypeScope.ReflectionUtil.EsDecimal(_objeto as Type);
                }
                else if (_objeto is PropertyInfo)
                {
                    return  InfoScope.ReflectionUtil.EsDecimal(_objeto as PropertyInfo);
                }
                else
                {
                    return  ObjectScope.ReflectionUtil.EsDecimal(_objeto);
                }
            }
            catch (UtilException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw  new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un objeto, tipo o propiedad es de tipo creado por el usuario (no primitivo) o de C#(primitivo).
        /// De ser un tipo, llama a TypeScope con _objeto as Type. Si es una propiedad, llama a InfoScope con _objeto as PropertyInfo.
        /// De lo contrario, llama a ObjectScope con el objeto.
        /// <example>
        ///     bool a = false;                 --> Primitivo
        ///     string a = "Hola Mundo";        --> Primitivo
        ///     String a = String.Empty;        --> Primitivo
        ///     UsuarioTO a = new UsuarioTO();  --> No primitivo.
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
        /// <param name="_objeto">Objeto, tipo o propiedad a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsNumero(this object _objeto)
        {
            try
            {
                if (_objeto is Type)
                {
                    return  TypeScope.ReflectionUtil.EsNumero(_objeto as Type);
                }
                else if (_objeto is PropertyInfo)
                {
                    return  InfoScope.ReflectionUtil.EsNumero(_objeto as PropertyInfo);
                }
                else
                {
                    return  ObjectScope.ReflectionUtil.EsNumero(_objeto);
                }
            }
			catch(UtilException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw  new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un objeto es de tipo bool.
        /// De ser un tipo, llama a TypeScope con _objeto as Type. Si es una propiedad, llama a InfoScope con _objeto as PropertyInfo.
        /// De lo contrario, llama a ObjectScope con el objeto.
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
        /// <param name="_objeto">Objeto a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsBooleano(this object _objeto)
        {
            try
            {
                if (_objeto is Type)
                {
                    return  TypeScope.ReflectionUtil.EsBooleano(_objeto as Type);
                }
                else if (_objeto is PropertyInfo)
                {
                    return  InfoScope.ReflectionUtil.EsBooleano(_objeto as PropertyInfo);
                }
                else
                {
                    return  ObjectScope.ReflectionUtil.EsBooleano(_objeto);
                }
            }
			catch(UtilException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw  new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un objeto, tipo o propiedad es de tipo string. Opcionalmente ofrece que interprete un char como string o no.
        /// Por defecto no se toma un char como string.
        /// De ser un tipo, llama a TypeScope con _objeto as Type. Si es una propiedad, llama a InfoScope con _objeto as PropertyInfo.
        /// De lo contrario, llama a ObjectScope con el objeto.
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
        /// <param name="_objeto">Objeto, tipo o propiedad a comprobar.</param>
        /// <param name="_incluirChar">Indica si se debe tratar a un char como un string. [Opcional]</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsString(this object _objeto, bool _incluirChar = false)
        {
            try
            {
                if (_objeto is Type)
                {
                    return  TypeScope.ReflectionUtil.EsString(_objeto as Type, _incluirChar);
                }
                else if (_objeto is PropertyInfo)
                {
                    return  InfoScope.ReflectionUtil.EsString(_objeto as PropertyInfo, _incluirChar);
                }
                else
                {
                    return  ObjectScope.ReflectionUtil.EsString(_objeto, _incluirChar);
                }
            }
			catch(UtilException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw  new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Obtiene el tipo (AssemblyQualifiedName) en singular de una colección.
        /// De ser un tipo, llama a TypeScope con _objeto as Type. Si es una propiedad, llama a InfoScope con _objeto as PropertyInfo.
        /// De lo contrario, llama a ObjectScope con el objeto.
        /// <example>
        ///     string tS = TipoSingular(IList of UsuarioTO);
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
        /// <param name="_objeto">Objeto, tipo o propiedad a comprobar.</param>
        /// <returns>AssemblyQualifiedName del tipo en singular.</returns>
        public static string ObtenerTipoSingular(this object _objeto)
        {
            try
            {
                if (_objeto is Type)
                {
                    return TypeScope.ReflectionUtil.ObtenerTipoSingular(_objeto as Type);
                }
                else if (_objeto is PropertyInfo)
                {
                    return InfoScope.ReflectionUtil.ObtenerTipoSingular(_objeto as PropertyInfo);
                }
                else
                {
                    return ObjectScope.ReflectionUtil.ObtenerTipoSingular(_objeto);
                }
            }
			catch(UtilException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Cambia el valor de la propiedad de un objeto, mediante reflexión.Además es válido enviar la propiedad de una propiedad
        /// del modo "Direccion.NumeroCasa". 
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
        /// <param name="objeto">Objeto.</param>
        /// <param name="propiedad">Nombre de la propiedad.</param>
        /// <param name="valor">Valor de la propiedad.</param>
        public static void SetValorPropiedad(this object objeto, string propiedad, object valor)
        {
            ObjectScope.ReflectionUtil.SetValorPropiedad(objeto, propiedad, valor);
        }

        /// <summary>
        /// Obtiene el valor de la propiedad de un objeto, especificado, mediante reflexión. Además es válido enviar la propiedad de una propiedad
        /// del modo "Direccion.NumeroCasa". 
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
        /// <param name="objeto">Objeto.</param>
        /// <param name="propiedad">Nombre de la propiedad.</param>
        /// <returns></returns>
        public static object GetValorPropiedad(this object objeto, string propiedad)
        {
            return InfoScope.ReflectionUtil.GetValorPropiedad(objeto, propiedad);
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
        /// <param name="tipo">Tipo de la instancia.</param>
        /// <param name="parametros">Array de parametros del contructor de ese tipo.</param>
        /// <returns></returns>
        public static object CrearInstancia(string tipo, object[] parametros = null)
        {
            return ObjectScope.ReflectionUtil.CrearInstancia(tipo, parametros);
        }
    }
}
