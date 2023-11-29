using System.Reflection;

namespace RepositoryAndUnitOfWorkDemo.Utils
{
    public class GenericKeyValueUtil<TModel> where TModel : class
    {
        //Declaring a Generic Handler Class which will actually give Property Name,Value for any given class.
            public dynamic PrintTModelPropertyAndValue(TModel tmodelObj, string propertyName)
            {
                //Getting Type of Generic Class Model
                Type tModelType = tmodelObj.GetType();

                //We will be defining a PropertyInfo Object which contains details about the class property 
                PropertyInfo[] arrayPropertyInfos = tModelType.GetProperties();

                //Now we will loop in all properties one by one to get value
                foreach (PropertyInfo property in arrayPropertyInfos)
                {
                    if (property.Name == propertyName)
                        return property.GetValue(tmodelObj);
                    
                }
                return null;
           }
    }
}
