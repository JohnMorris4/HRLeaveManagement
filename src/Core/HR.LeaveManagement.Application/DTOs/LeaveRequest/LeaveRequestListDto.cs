using System;
using HR.LeaveManagement.Application.DTOs.Common;


namespace HR.LeaveManagement.Application.DTOs
{
    public class LeaveRequestListDto : BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }
        
    }
}