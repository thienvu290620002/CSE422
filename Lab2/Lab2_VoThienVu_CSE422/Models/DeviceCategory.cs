using System.ComponentModel.DataAnnotations;

namespace Lab2_VoThienVu_CSE422.Models
{
    public class DeviceCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Device> Devices { get; set; }
    }
}
