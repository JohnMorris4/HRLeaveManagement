using System.Collections.Generic;
using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {
        
    }
}