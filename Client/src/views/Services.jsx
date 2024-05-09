import { useEffect, useState } from "react"
import { getServices } from "../services/serviceData"


export const Services = () => {
    const [services, setServices] = useState([])

    useEffect(() => {
       getServices().then(setServices) 
    }, [])

    return (
        <div className="main-container">
            <h3>Here are your gosh-darned services:</h3>
            {services.map((s) => (
                <div key={s.id} className="sub-container">
                    <h4>Service Name: {s.name}</h4>
                    <h4>Price : ${s.price}</h4>
                </div>
            ))}
        </div>
    )
}