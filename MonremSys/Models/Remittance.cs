namespace MonremSys
{
    class Remittance : Transfer
    {
        Customer sender;
        Customer receiver;

        internal Customer Sender { get => sender; set => sender = value; }
        internal Customer Receiver { get => receiver; set => receiver = value; }

        public override string ToString()
        {
            return $@"Receiver: {Receiver.Name}
            Phone Number: {Receiver.Phone_number}
            Amount: {Amount} {Transfercurrency.Name}
            Comission: {Comission}
            Sender: {Sender.Name}
            Phone Number: {Sender.Phone_number}";
        }

    }
}
