pub fn production_rate_per_hour(speed: u8) -> f64 {
    let total_cars = speed as f64 * 221.0;

    match speed {
        0 => 0.0,
        1..=4 => total_cars.into(),
        5..=8 => total_cars * 0.9,
        9 | 10 => total_cars * 0.77,

        _ => panic!("invalid speed")
    }
}

pub fn working_items_per_minute(speed: u8) -> u32 {
    (production_rate_per_hour(speed) / 60.0) as u32
}
