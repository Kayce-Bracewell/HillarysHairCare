import { Link } from "react-router-dom"
import "./NavBar.css"

export const NavBar = () => {

    return (
        <ul className="navbar">
            <li className="navbar-item">
                <Link className="navbar-link" to="/">Home</Link>
            </li>
            <li className="navbar-item">
                <Link className="navbar-link" to="/services">Services</Link>
            </li>
        </ul>
    )
}