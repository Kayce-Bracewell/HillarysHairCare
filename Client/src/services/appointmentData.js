const _apiUrl = "/api/appointments"

export const GetAppointments = async () => {
    return fetch(`${_apiUrl}`).then(res => res.json())
}