import { useEffect, useState } from "react"
import "./Home.css"
import { GetAppointments } from "../services/appointmentData"


export const Home = () => {
    const [appointments, setAppointments] = useState([])

    useEffect(() => {
        GetAppointments().then(setAppointments)
    }, [])

    return (
        <div>
            <h1>Welcome to Hillary's Hair Care!</h1>
            <div className="appointment-container">
                {appointments.map((a) => (
                    <div key={a.id} className="sub-container">
                        <h4>Customer Name: {a.customer.name}</h4>
                        <h4>Stylist Name: {a.stylist.name}</h4>
                        <h4>Appt. Cost: {a.totalCost}</h4>
                    </div>
                ))}
                <h4>Is this working?</h4>
            </div>
        </div>
    )
}