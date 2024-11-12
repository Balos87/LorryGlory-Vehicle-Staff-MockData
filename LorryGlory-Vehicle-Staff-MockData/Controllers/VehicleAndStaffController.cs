using Microsoft.AspNetCore.Mvc;
using LorryGloryMockApi.Data.Models.Vehicle;
using LorryGloryMockApi.Data.Models.Vehicle.Enums;
using System;
using LorryGlory.Data.Models.Staff.Enums;
using LorryGlory.Data.Models.Staff;

namespace LorryGlory_Vehicle_Staff_MockData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleAndStaffController : ControllerBase
    {
        [HttpGet("vehicle")]
        public IActionResult GetVehicle()
        {
            var vehicle = new VehicleModel
            {
                Id = Guid.NewGuid(),
                RegNo = "BJG11K",
                Vin = "YS2G8X40002163153",
                Make = "SCANIA",
                Model = "G500B8X4*4NB",
                Color = "White",
                Type = "Truck",
                VehicleYear = 2019,
                ModelYear = 2019,
                StolenStatus = "Not Stolen",
                Status = new VehicleStatus
                {
                    Id = 1,
                    Status = "In Traffic",
                    FirstRegistered = new DateOnly(2019, 10, 30)
                },
                Inspection = new Inspection
                {
                    Id = 1,
                    LatestInspection = new DateOnly(2024, 10, 30),
                    InspectionValidUntil = new DateOnly(2025, 10, 31),
                    Meter = 145902
                },
                TechnicalData = new TechnicalData
                {
                    Id = 1,
                    PowerHp = 500,
                    PowerKw = 368,
                    CylinderVolume = 12742,
                    Fuel = FuelType.Diesel.ToString(),
                    Transmission = TransmissionType.Automat.ToString(),
                    FourWheelDrive = false,
                    Chassi = ChassiType.Lastbil.ToString(),
                    Length = 9390,
                    Width = 2600,
                    Height = 3600,
                    KerbWeight = 21410,
                    TotalWeight = 33000,
                    LoadWeight = 11590,
                    TrailerWeight = 0,
                    UnbrakedTrailerWeight = 0,
                    TrailerWeightB = 0,
                    TrailerWeightBe = 0,
                    CarriageWeight = 0,
                    TireFront = "385/55R22.5",
                    TireBack = "315/70R22.5",
                    AxleWidth1 = 3950,
                    AxleWidth2 = 1350,
                    AxleWidth3 = 1300,
                    Category = "N3"
                },
                Eco = new EcoDetails
                {
                    Id = 1,
                    EuroClass = "EURO 6"
                }
            };

            return Ok(vehicle);
        }

        [HttpGet("employee")]
        public IActionResult GetEmployee()
        {
            var employee = new Staff
            {
                Id = Guid.NewGuid(),
                Roles = new List<Role> { Role.Employee },
                JobTitle = JobTitle.Driver,
                FirstName = "John",
                LastName = "Doe",
                PersonalNumber = "19851130-1234",
                Email = "johndoe@example.com",
                PhoneNumber = "+46123456789",
                PreferredLanguage = "English"
            };

            return Ok(employee);
        }

    }
}
