using SimpleMqtt;

SimpleMqttClient client = SimpleMqttClient.CreateSimpleMqttClientForHiveMQ("laptop");
await client.PublishMessage("uhm", "nadenken");

await client.PublishMessage("Hoi hier test ben ik", "test");

client.OnMessageReceived += (sender, args) => 
{
    Console.WriteLine($"Bericht ontvangen; topic={args.Topic}; message={args.Message}");
};

await client.SubscribeToTopic("TestMqtt");

Console.ReadLine();