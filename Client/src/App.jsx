import './App.css'
import { Outlet, Route, Routes } from 'react-router-dom'
import { Home } from './views/Home'
import { NavBar } from './views/NavBar'
import { Services } from './views/Services'

export const App = () => {

  return (
    <Routes>
      <Route path="/" element={
          <>
            <NavBar />
            <Outlet />
          </>
      }>
        <Route index element={<Home />}/>
        <Route path="/services" element={<Services />} />
      </Route>
    </Routes>
  )
}