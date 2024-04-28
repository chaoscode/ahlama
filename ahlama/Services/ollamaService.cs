using ahlama.Models.ollama;
using Newtonsoft.Json;

namespace ahlama.Services
{
    public class ollamaService
    {
        public TagsOutput ParseTags(string jsonData)
        {
            // This split each json object into the array
            TagsOutput msg = JsonConvert.DeserializeObject<TagsOutput>(jsonData);
            
            return msg;
        }
        public string processGenerateResponse(string jsonData)
        {
            // Create List object of output
            List<GenerateOutput> list = new List<GenerateOutput>();
            string response;

            if (!string.IsNullOrEmpty(jsonData))
            {
                try
                {
                    // This split each json object into the array
                    var split = jsonData.Split("\n");

                    foreach (var message in split)
                    {
                        GenerateOutput msg = JsonConvert.DeserializeObject<GenerateOutput>(message);

                        if (msg != null)
                        {
                            list.Add(msg);
                        }

                    }

                    response = String.Join("", list.Select(item => item.response));
                }
                catch 
                {
                    response = $"Error while processing request.{Environment.NewLine}Please Try Again{Environment.NewLine}";
                }
            }
            else
            {
                response = $"Error while processing request.{Environment.NewLine}Please Try Again{Environment.NewLine}";
            }

            return response;
        }
    }
}
