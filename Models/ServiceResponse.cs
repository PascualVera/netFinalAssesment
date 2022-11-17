namespace finalAssesmentLaBestia.Models
{
  
        public class ServiceResponse<T>
        {

        public ServiceResponse(bool ok, T? data)
        {
            Ok = ok;
            Data = data;
        }

        public bool Ok { get; set; }
        public T? Data { get; set; }
            
       
        }
    
}
