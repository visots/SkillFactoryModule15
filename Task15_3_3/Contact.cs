namespace Task15_3_3
{
    internal class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }   


        public Contact(string name, long phone, string email)
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
        }
    }
}