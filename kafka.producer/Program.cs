using Confluent.Kafka;

var producerConfig = new ProducerConfig
{
    BootstrapServers = "localhost:9092"
};

using var producer = new ProducerBuilder<string, string>(producerConfig).Build();

var message = new Message<string, string>
{
    Key = "sample-key",
    Value = "Hello from Kafka in Docker!"
};

await producer.ProduceAsync("sample-topic", message);
Console.WriteLine("Message sent!");