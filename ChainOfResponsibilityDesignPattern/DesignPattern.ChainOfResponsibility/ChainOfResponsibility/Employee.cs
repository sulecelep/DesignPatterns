using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover; //Sonraki Onaylayıcı
        public void SetNextApprover(Employee superVisor) //Sonraki Onaylayıcıyı Atama
        {
            this.NextApprover = superVisor; //Sonraki onaylayıcım parametreden gelen değer olacak
        }
        public abstract void ProcessRequest(CustomerProcessViewModel req);
    }
}
