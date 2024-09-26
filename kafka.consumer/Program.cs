using Confluent.Kafka;

var consumerConfig = new ConsumerConfig
{
    BootstrapServers = "localhost:9092",
    GroupId = "sample-group",
    AutoOffsetReset = AutoOffsetReset.Earliest
};

using var consumer = new ConsumerBuilder<string, string>(consumerConfig).Build();
consumer.Subscribe("sample-topic");

var consumeResult = consumer.Consume();
Console.WriteLine($"Message consumed: {consumeResult.Message.Value}");